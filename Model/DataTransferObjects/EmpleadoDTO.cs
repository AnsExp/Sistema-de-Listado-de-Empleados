using Model.Entities;
using System;

namespace Model.DataTransferObjects
{
    public class EmpleadoDTO
    {
        public EmpleadoDTO() { }

        public EmpleadoDTO
            (Documento documento)
        {
            this.documento = documento;
        }

        public EmpleadoDTO
            (string nombres,
            string apellidos,
            int edad,
            string cargo,
            DateTime fechaIngreso,
            DateTime fechaRetiro,
            Foto fotoPerfil,
            Documento documento)
        {
            this.edad = edad;
            this.cargo = cargo;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.documento = documento;
            this.fotoPerfil = fotoPerfil;
            this.fechaRetiro = fechaRetiro;
            this.fechaIngreso = fechaIngreso;
        }

        private readonly int edad;
        private readonly string cargo;
        private readonly string nombres;
        private readonly Foto fotoPerfil;
        private readonly string apellidos;
        private readonly Documento documento;
        private readonly DateTime fechaRetiro;
        private readonly DateTime fechaIngreso;

        public int Edad { get { return edad; } }
        public string Cargo { get { return cargo; } }
        public string Nombres { get { return nombres; } }
        public string Apellidos { get { return apellidos; } }
        public Foto FotoPerfil { get { return fotoPerfil; } }
        public Documento Documento { get { return documento; } }
        public DateTime FechaRetiro { get { return fechaRetiro; } }
        public DateTime FechaIngreso { get { return fechaIngreso; } }
    }
}
