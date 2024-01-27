using Controller.Controles;
using System;
using System.Windows.Forms;

namespace View
{
    internal class AgregarEmpleado : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button insert;
        private TextBox numeroDocumento;
        private TextBox salario;
        private TextBox cargo;
        private TextBox name;
        private TextBox lastName;
        private DateTimePicker fechaNacimiento;
        private DateTimePicker fechaIngreso;
        private ComboBox tipoDocumento;
        private Label label9;
        private Button buttonFotoPerfil;
        private OpenFileDialog fotoPerfil;
        private Label label2;

        public AgregarEmpleado()
        {
            InitializeComponent();
            InitializeListener();
        }

        private readonly ControlEmpleado control = new ControlEmpleado();

        private void InitializeListener()
        {
            control.Name = name;
            control.Cargo = cargo;
            control.Salario = salario;
            control.LastName = lastName;
            control.FechaIngreso = fechaIngreso;
            control.TipoDocumento = tipoDocumento;
            control.FotoPerfilURL = buttonFotoPerfil;
            control.FechaNacimiento = fechaNacimiento;
            control.NumeroDocumento = numeroDocumento;
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.buttonFotoPerfil = new System.Windows.Forms.Button();
            this.fotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numeroDocumento, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.salario, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cargo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.insert, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.fechaNacimiento, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fechaIngreso, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tipoDocumento, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFotoPerfil, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Seleccionar Foto Perfil:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeroDocumento.Location = new System.Drawing.Point(340, 99);
            this.numeroDocumento.MaxLength = 10;
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(141, 20);
            this.numeroDocumento.TabIndex = 16;
            // 
            // salario
            // 
            this.salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salario.Location = new System.Drawing.Point(340, 35);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(141, 20);
            this.salario.TabIndex = 12;
            // 
            // cargo
            // 
            this.cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cargo.Location = new System.Drawing.Point(99, 35);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(139, 20);
            this.cargo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(244, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(244, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario ($):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(244, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Ingreso:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo documento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(244, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Número documento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // insert
            // 
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert.Location = new System.Drawing.Point(340, 131);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(141, 27);
            this.insert.TabIndex = 8;
            this.insert.Text = "Agregar";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Location = new System.Drawing.Point(99, 3);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(139, 20);
            this.name.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Location = new System.Drawing.Point(340, 3);
            this.lastName.MaxLength = 30;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(141, 20);
            this.lastName.TabIndex = 10;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.Location = new System.Drawing.Point(99, 67);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(139, 20);
            this.fechaNacimiento.TabIndex = 13;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(340, 67);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(141, 20);
            this.fechaIngreso.TabIndex = 14;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocumento.FormattingEnabled = true;
            this.tipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte",
            "Carné de Refugiado",
            "Carné de Solicitante de Refugio"});
            this.tipoDocumento.Location = new System.Drawing.Point(99, 99);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(139, 21);
            this.tipoDocumento.TabIndex = 15;
            // 
            // buttonFotoPerfil
            // 
            this.buttonFotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFotoPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFotoPerfil.Location = new System.Drawing.Point(99, 131);
            this.buttonFotoPerfil.Name = "buttonFotoPerfil";
            this.buttonFotoPerfil.Size = new System.Drawing.Size(139, 27);
            this.buttonFotoPerfil.TabIndex = 18;
            this.buttonFotoPerfil.Text = "Seleccionar Foto";
            this.buttonFotoPerfil.UseVisualStyleBackColor = true;
            this.buttonFotoPerfil.Click += new System.EventHandler(this.buttonFotoPerfil_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.FileName = "fotoPerfil";
            this.fotoPerfil.Filter = "Formato imagen|*.jpg; *.jpeg; *.png";
            // 
            // AgregarEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEmpleado";
            this.ShowIcon = false;
            this.Text = "Agregar Empleado";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void insert_Click(object sender, EventArgs e)
        {
            control.InsertEvent();
        }

        private void buttonFotoPerfil_Click(object sender, EventArgs e)
        {
            if (fotoPerfil.ShowDialog() == DialogResult.OK)
            {
                buttonFotoPerfil.Text = fotoPerfil.FileName;

                Console.WriteLine(fotoPerfil.FileName);
            }
        }
    }
}
