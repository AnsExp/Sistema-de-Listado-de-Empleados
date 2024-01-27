using Model.Entities;
using System;

namespace Model.Builders
{
    public class EmpleadoBuilder : IBuilder<EmpleadoEntity>
    {
        public EmpleadoBuilder Salario(int salario)
        {
            this.salario = salario;
            return this;
        }

        public EmpleadoBuilder Cargo(string cargo)
        {
            this.cargo = cargo;
            return this;
        }

        public EmpleadoBuilder Nombres(string nombres)
        {
            this.nombres = nombres;
            return this;
        }

        public EmpleadoBuilder Apellidos(string apellidos)
        {
            this.apellidos = apellidos;
            return this;
        }

        public EmpleadoBuilder Documento(Documento documento)
        {
            this.documento = documento;
            return this;
        }

        public EmpleadoBuilder FotoPerfil(Foto fotoPerfilUrl)
        {
            this.fotoPerfilUrl = fotoPerfilUrl;
            return this;
        }

        public EmpleadoBuilder FechaRetiro(DateTime fechaRetiro)
        {
            this.fechaRetiro = fechaRetiro;
            return this;
        }

        public EmpleadoBuilder FechaIngreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
            return this;
        }

        public EmpleadoBuilder FechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
            return this;
        }

        private int salario;
        private string cargo;
        private string nombres;
        private string apellidos;
        private Documento documento;
        private Foto fotoPerfilUrl;
        private DateTime fechaRetiro;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;

        public EmpleadoEntity Build()
        {
            return new EmpleadoEntity
                (salario,
                nombres,
                apellidos,
                cargo,
                documento,
                fotoPerfilUrl,
                fechaNacimiento,
                fechaIngreso,
                fechaRetiro);
        }
    }
}
