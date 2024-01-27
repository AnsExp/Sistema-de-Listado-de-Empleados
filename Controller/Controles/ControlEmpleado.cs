using Controller.Exceptions;
using Controller.Verifies;
using Model.Builders;
using Model.DataAccessObject;
using Model.DataTransferObjects;
using Model.Entities;
using Model.Mappers;
using System;
using System.Windows.Forms;

namespace Controller.Controles
{
    public class ControlEmpleado : IControl
    {
        public TextBox Name {  get; set; }
        public TextBox Cargo {  get; set; }
        public TextBox Salario {  get; set; }
        public TextBox LastName {  get; set; }
        public CheckBox Inactivo {  get; set; }
        public Button FotoPerfilURL {  get; set; }
        public ComboBox TipoDocumento {  get; set; }
        public TextBox NumeroDocumento {  get; set; }
        public DateTimePicker FechaRetiro {  get; set; }
        public DateTimePicker FechaIngreso {  get; set; }
        public DateTimePicker FechaNacimiento {  get; set; }

        private IDataAccess<EmpleadoEntity> DAO = new EmpleadoDAO();
        private EmpleadoDTO registro;

        public void DeleteEvent()
        {
            try
            {
                Verify.VerifyText(
                        TipoDocumento.Text,
                        NumeroDocumento.Text);
                
                Verify.VerifyFormat(
                    NumeroDocumento.Text,
                    FormatType.NumericFormat);

                DAO.Delete(new EmpleadoEntity(
                    new Documento(
                        TipoDocumento.Text,
                        NumeroDocumento.Text)));

                TipoDocumento.SelectedItem = null;
                NumeroDocumento.Text = string.Empty;

                ControlGrid.ControlGrid.LoadRegisters();
            }
            catch (FieldErrorException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertEvent()
        {
            try
            {
                int diferenciaEnAnios = FechaIngreso.Value.Year - FechaNacimiento.Value.Year;

                if (FechaIngreso.Value.Month < FechaNacimiento.Value.Month ||
                    (FechaIngreso.Value.Month == FechaNacimiento.Value.Month &&
                    FechaIngreso.Value.Day < FechaNacimiento.Value.Day))
                {
                    diferenciaEnAnios--;
                }

                Verify.VerifyText(
                        Name.Text,
                        Cargo.Text,
                        Salario.Text,
                        //FotoPerfilURL.Text,
                        LastName.Text,
                        FotoPerfilURL.Text,
                        TipoDocumento.SelectedItem.ToString(),
                        NumeroDocumento.Text);

                Verify.VerifyFormat(
                    NumeroDocumento.Text,
                    FormatType.NumericFormat);

                Verify.VerifyLogic(
                    diferenciaEnAnios < 18,
                    "El empleado debe tener un mínimo de 18 años.");

                int sueldo = Convert.ToInt32(Salario.Text);

                EmpleadoBuilder builder = new EmpleadoBuilder();

                builder
                    .Cargo(Cargo.Text)
                    .Nombres(Name.Text)
                    .Salario(sueldo)
                    .Apellidos(LastName.Text)
                    .FechaIngreso(FechaIngreso.Value)
                    .FechaNacimiento(FechaNacimiento.Value)
                    .FotoPerfil(new Foto(
                        FotoPerfilURL.Text.Equals("Seleccionar Foto") ?
                        null :
                        FotoPerfilURL.Text))
                    .Documento(new Documento(
                        TipoDocumento.SelectedItem.ToString(),
                        NumeroDocumento.Text));

                Name.Text = string.Empty;
                Cargo.Text = string.Empty;
                Salario.Text = string.Empty;
                LastName.Text = string.Empty;
                TipoDocumento.Text = string.Empty;
                TipoDocumento.SelectedItem = null;
                FechaIngreso.Value = DateTime.Now;
                FechaNacimiento.Value = DateTime.Now;
                FotoPerfilURL.Text = "Seleccionar Foto";

                DAO.Insert(builder.Build());
                
                ControlGrid.ControlGrid.LoadRegisters();
            }
            catch(FieldErrorException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de numero equivocado");
            }
        }

        public void SelectEvent()
        {
            try
            {
                Verify.VerifyText(
                        TipoDocumento.SelectedItem.ToString(),
                        NumeroDocumento.Text);

                Verify.VerifyFormat(
                    NumeroDocumento.Text,
                    FormatType.NumericFormat);

                registro = new EmpleadoMapper().Mapping(
                    DAO.Select(new EmpleadoEntity(
                        new Documento(
                            TipoDocumento.SelectedItem.ToString(),
                            NumeroDocumento.Text))));

                Verify.VerifyLogic(
                    registro == null,
                    "No se encontró ningún registro.");

                Name.Text = registro.Nombres;
                LastName.Text = registro.Apellidos;
                Cargo.Text = registro.Cargo;
                FotoPerfilURL.Text = 
                    registro.FotoPerfil.PathIn.Equals(string.Empty) ? 
                    "Seleccionar Foto" : 
                    registro.FotoPerfil.PathIn;
            }
            catch (FieldErrorException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateEvent()
        {
            try
            {
                Verify.VerifyLogic(
                    registro == null,
                    "No ha cargado ningún registro.");

                Verify.VerifyText(
                        Name.Text,
                        Cargo.Text,
                        Salario.Text,
                        LastName.Text,
                        FotoPerfilURL.Text);

                if (Inactivo.Checked)
                {
                    Verify.VerifyLogic(
                        FechaRetiro.Value < registro.FechaIngreso,
                        "La fecha de retiro debe ser posterios a la fecha de ingreso.");
                }

                Verify.VerifyFormat(
                    Salario.Text,
                    FormatType.NumericFormat);

                EmpleadoBuilder builder = new EmpleadoBuilder();
                
                int sueldo = Convert.ToInt32(Salario.Text);

                builder
                    .Cargo(Cargo.Text)
                    .Nombres(Name.Text)
                    .Salario(sueldo)
                    .Apellidos(LastName.Text)
                    .FechaRetiro(Inactivo.Checked ? FechaRetiro.Value : DateTime.Parse("1/1/1753"))
                    .Documento(registro.Documento)
                    .FotoPerfil(registro.FotoPerfil);

                TipoDocumento.SelectedItem = null;
                NumeroDocumento.Text = string.Empty;
                Name.Text = string.Empty;
                Cargo.Text = string.Empty;
                Salario.Text = string.Empty;
                FotoPerfilURL.Text = string.Empty;
                LastName.Text = string.Empty;
                Inactivo.Checked = false;
                FechaRetiro.Enabled = false;

                registro = null;

                DAO.Update(builder.Build());

                ControlGrid.ControlGrid.LoadRegisters();
            }
            catch (FieldErrorException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de numero equivocado");
            }
        }
    }
}
