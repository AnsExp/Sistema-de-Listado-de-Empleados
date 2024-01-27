using Controller.Controles;
using System;
using System.Windows.Forms;

namespace View
{
    internal class ActualizarEmpleado : Form
    {
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox names;
        private Button select;
        private Button update;
        private TextBox cargo;
        private TextBox salario;
        private TextBox lastname;
        private CheckBox inactivo;
        private ComboBox tipoDocumento;
        private TextBox numeroDocumento;
        private Button buttonFotoPerfil;
        private OpenFileDialog fotoPerfil;
        private DateTimePicker fechaRetiro;
        private TableLayoutPanel tableLayoutPanel1;

        public ActualizarEmpleado()
        {
            InitializeComponent();
            InitializeListener();
        }

        private readonly ControlEmpleado control = new ControlEmpleado();

        private void InitializeListener()
        {
            control.TipoDocumento = tipoDocumento;
            control.NumeroDocumento = numeroDocumento;

            control.Name = names;
            control.Cargo = cargo;
            control.Salario = salario;
            control.Inactivo = inactivo;
            control.LastName = lastname;
            control.FechaRetiro = fechaRetiro;
            control.FotoPerfilURL = buttonFotoPerfil;
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.salario = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.inactivo = new System.Windows.Forms.CheckBox();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.buttonFotoPerfil = new System.Windows.Forms.Button();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.fotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.fechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(244, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Documento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cargo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(244, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salario ($):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccionar Foto Perfil:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // select
            // 
            this.select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select.Location = new System.Drawing.Point(340, 35);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(141, 26);
            this.select.TabIndex = 10;
            this.select.Text = "Buscar";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // names
            // 
            this.names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.names.Location = new System.Drawing.Point(99, 35);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(139, 20);
            this.names.TabIndex = 5;
            // 
            // cargo
            // 
            this.cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cargo.Location = new System.Drawing.Point(99, 99);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(139, 20);
            this.cargo.TabIndex = 13;
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update.Location = new System.Drawing.Point(340, 131);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(141, 27);
            this.update.TabIndex = 11;
            this.update.Text = "Actualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // salario
            // 
            this.salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salario.Location = new System.Drawing.Point(340, 99);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(141, 20);
            this.salario.TabIndex = 15;
            // 
            // lastname
            // 
            this.lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastname.Location = new System.Drawing.Point(99, 67);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(139, 20);
            this.lastname.TabIndex = 6;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inactivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inactivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inactivo.Location = new System.Drawing.Point(244, 67);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(90, 26);
            this.inactivo.TabIndex = 16;
            this.inactivo.Text = "Inactivo";
            this.inactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inactivo.UseVisualStyleBackColor = true;
            this.inactivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.tipoDocumento.Location = new System.Drawing.Point(99, 3);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(139, 21);
            this.tipoDocumento.TabIndex = 1;
            // 
            // buttonFotoPerfil
            // 
            this.buttonFotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFotoPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFotoPerfil.Location = new System.Drawing.Point(99, 131);
            this.buttonFotoPerfil.Name = "buttonFotoPerfil";
            this.buttonFotoPerfil.Size = new System.Drawing.Size(139, 27);
            this.buttonFotoPerfil.TabIndex = 9;
            this.buttonFotoPerfil.Text = "Seleccionar Foto";
            this.buttonFotoPerfil.UseVisualStyleBackColor = true;
            this.buttonFotoPerfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeroDocumento.Location = new System.Drawing.Point(340, 3);
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(141, 20);
            this.numeroDocumento.TabIndex = 3;
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.FileName = "openFileDialog1";
            // 
            // fechaRetiro
            // 
            this.fechaRetiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaRetiro.Enabled = false;
            this.fechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRetiro.Location = new System.Drawing.Point(340, 67);
            this.fechaRetiro.Name = "fechaRetiro";
            this.fechaRetiro.Size = new System.Drawing.Size(141, 20);
            this.fechaRetiro.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tipoDocumento, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numeroDocumento, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.select, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cargo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.salario, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.names, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inactivo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fechaRetiro, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonFotoPerfil, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.update, 3, 4);
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
            // ActualizarEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarEmpleado";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Actualizar Empleado";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fechaRetiro.Enabled = inactivo.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fotoPerfil.ShowDialog() == DialogResult.OK)
            {
                buttonFotoPerfil.Text = fotoPerfil.FileName;

                Console.WriteLine(fotoPerfil.FileName);
            }
        }
        
        private void select_Click(object sender, EventArgs e)
        {
            control.SelectEvent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            control.UpdateEvent();
        }
    }
}
