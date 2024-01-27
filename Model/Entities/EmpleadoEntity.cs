using System;

namespace Model.Entities
{
    public class EmpleadoEntity
    {
        public EmpleadoEntity
            (Documento documento)
        {
            this.documento = documento;
        }

        public EmpleadoEntity
            (int salario,
            string nombres,
            string apellidos,
            string cargo,
            Foto fotoPerfilUrl,
            DateTime fechaNacimiento,
            DateTime fechaIngreso,
            DateTime fechaRetiro)
        {
            this.cargo = cargo;
            this.salario = salario;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaRetiro = fechaRetiro;
            this.fechaIngreso = fechaIngreso;
            this.fotoPerfilUrl = fotoPerfilUrl;
            this.fechaNacimiento = fechaNacimiento;
        }

        public EmpleadoEntity
            (int salario,
            string nombres,
            string apellidos,
            string cargo,
            Documento documento,
            Foto fotoPerfilUrl,
            DateTime fechaNacimiento,
            DateTime fechaIngreso,
            DateTime fechaRetiro)
        {
            this.cargo = cargo;
            this.salario = salario;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.documento = documento;
            this.fechaRetiro = fechaRetiro;
            this.fechaIngreso = fechaIngreso;
            this.fotoPerfilUrl = fotoPerfilUrl;
            this.fechaNacimiento = fechaNacimiento;
        }

        private readonly int salario;
        private readonly string cargo;
        private readonly string nombres;
        private readonly string apellidos;
        private readonly Foto fotoPerfilUrl;
        private readonly Documento documento;
        private readonly DateTime fechaRetiro;
        private readonly DateTime fechaIngreso;
        private readonly DateTime fechaNacimiento;

        public string Cargo { get { return cargo; } }
        public int Salario { get { return salario; } }
        public string Nombres { get { return nombres; } }
        public string Apellidos { get { return apellidos; } }
        public Foto FotoPerfil { get { return fotoPerfilUrl; } }
        public Documento Documento { get { return documento; } }
        public DateTime FechaRetiro { get { return fechaRetiro; } }
        public DateTime FechaIngreso { get { return fechaIngreso; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } }
    }
}
