using Model.Builders;
using Model.DataAccessObject;
using Model.DataTransferObjects;
using Model.Entities;
using System;

namespace Model.Mappers
{
    public class EmpleadoMapper : IMapper<EmpleadoDTO, EmpleadoEntity>
    {
        public EmpleadoDTO Mapping(EmpleadoEntity value)
        {
            if (value == null) return null;

            Documento documento = value.Documento;
            string nombres = value.Nombres;
            string apellidos = value.Apellidos;
            string cargo = value.Cargo;
            DateTime fechaIngreso = value.FechaIngreso;
            DateTime fechaRetiro = value.FechaRetiro;
            Foto fotoPerfil = value.FotoPerfil;
            int edad = DateTime.Today.Year - value.FechaNacimiento.Year;

            if (value.FechaNacimiento > DateTime.Today.AddYears(-edad))
                edad--;

            return new EmpleadoDTO
                (nombres,
                apellidos,
                edad,
                cargo,
                fechaIngreso,
                fechaRetiro,
                fotoPerfil,
                documento);
        }

        public EmpleadoEntity Mapping(EmpleadoDTO value)
        {
            if (value == null) return null;
            
            EmpleadoEntity bucarempleado = new EmpleadoEntity(value.Documento);
            EmpleadoEntity emp = new EmpleadoDAO().Select(bucarempleado);

            EmpleadoEntity empleado = new EmpleadoBuilder()
                .Cargo(value.Cargo)
                .Nombres(value.Nombres)
                .Apellidos(value.Apellidos)
                .Documento(value.Documento)
                .FotoPerfil(value.FotoPerfil)
                .FechaRetiro(value.FechaRetiro)
                .FechaIngreso(value.FechaIngreso)
                .Salario(emp.Salario)
                .FechaNacimiento(emp.FechaNacimiento)
                .Build();

            return empleado;
        }
    }
}
