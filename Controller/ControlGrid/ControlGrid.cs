using Model.Connection;
using Model.DataAccessObject;
using Model.DataTransferObjects;
using Model.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controller.ControlGrid
{
    public sealed class ControlGrid
    {
        public static DataGridView Grid { get; set; }
        private static List<string> fotos = new List<string>();

        private ControlGrid() { }

        public static void LoadRegisters()
        {
            Grid.Rows.Clear();

            List<EmpleadoDTO> list = new EmpleadoDAO().
                SelectAll()
                .Select(
                x => new EmpleadoMapper().Mapping(x))
                .ToList();

            fotos.Clear();

            foreach (EmpleadoDTO emp in list)
            {
                int i = Grid.Rows.Add();
                DataGridViewRow row = Grid.Rows[i];

                row.Cells["photo"].Value = "Ver";
                row.Cells["age"].Value = emp.Edad;
                row.Cells["cargo"].Value = emp.Cargo;
                row.Cells["names"].Value = emp.Nombres;
                row.Cells["lastName"].Value = emp.Apellidos;
                row.Cells["dateAdmission"].Value = emp.FechaIngreso;
                row.Cells["dateRetirement"].Value =
                    emp.FechaRetiro.Year == 1 ||
                    emp.FechaRetiro.Year == 1753 ?
                    string.Empty :
                    emp.FechaRetiro.ToString();

                fotos.Add(emp.FotoPerfil == null ? string.Empty : emp.FotoPerfil.PathIn);

                Grid.Rows.RemoveAt(i);
                Grid.Rows.Add(row);
            }

            Grid.CellContentClick += new DataGridViewCellEventHandler(ComandoClick);
        }

        private static void ComandoClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Grid.Columns["photo"].Index)
            {
                if (string.IsNullOrEmpty(fotos[e.RowIndex])) return;

                MostrarImagen(fotos[e.RowIndex]);
            }
        }

        private static void MostrarImagen(string ruta)
        {
            PictureBox pictureBox = new PictureBox();

            var pic = System.Drawing.Image.FromFile(ruta);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = pic;
            pictureBox.Dock = DockStyle.Fill;

            Form form = new Form();
            form.Width = pictureBox.Width;
            form.Height = pictureBox.Height;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Text = "Visor de imagenes";
            form.ShowIcon = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }

        public static void ShowCount(TextBox countText)
        {
            try
            {
                int count = Convert.ToInt32(countText.Text);

                foreach(DataGridViewRow row in Grid.Rows)
                {
                    row.Visible = count < 1;
                }

                if (count < 1) return;
                
                int i = 0;

                foreach (DataGridViewRow row in Grid.Rows)
                {
                    row.Visible = true;
                    i++;

                    if (i == count) break;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Formato de número incorrecto.");
            }
        }

        public static void ShowRegisterByActivity(string fillter)
        {
            foreach (DataGridViewRow row in Grid.Rows)
            {
                if (fillter.Equals("Todos"))
                {
                    row.Visible = true;
                }
                else if(fillter.Equals("Activos"))
                {
                    if (row.Cells["dateRetirement"].Value == null)
                    {
                        row.Visible= true;
                        return;
                    }

                    DateTime fechaRetiro = Convert.ToDateTime(row.Cells["dateRetirement"].Value);
                    row.Visible = fechaRetiro > DateTime.Now;

                }
                else if (fillter.Equals("Inactivos"))
                {
                    if (row.Cells["dateRetirement"].Value == null)
                    {
                        row.Visible = false;
                        return;
                    }

                    DateTime fechaRetiro = Convert.ToDateTime(row.Cells["dateRetirement"].Value);
                    row.Visible = fechaRetiro < DateTime.Now;
                }
            }
        }

        public static void CloseGrid(object sender, EventArgs e)
        {
            DataBase.CloseConnection();
        }
    }
}
