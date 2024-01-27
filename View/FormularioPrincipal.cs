using Controller.ControlGrid;

namespace View
{
    internal class FormularioPrincipal : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CountEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeActivity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRetirement;
        private System.Windows.Forms.DataGridViewButtonColumn photo;
        private System.Windows.Forms.Label label1;

        public FormularioPrincipal()
        {
            InitializeComponent();
            ControlGrid.Grid = dataGridView1;
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(ControlGrid.CloseGrid);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountEmployee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typeActivity = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRetirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CountEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.typeActivity, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 337);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(334, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountEmployee
            // 
            this.CountEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountEmployee.Location = new System.Drawing.Point(120, 13);
            this.CountEmployee.MaxLength = 3;
            this.CountEmployee.Name = "CountEmployee";
            this.CountEmployee.Size = new System.Drawing.Size(101, 20);
            this.CountEmployee.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(227, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeActivity
            // 
            this.typeActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeActivity.FormattingEnabled = true;
            this.typeActivity.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.typeActivity.Location = new System.Drawing.Point(441, 13);
            this.typeActivity.Name = "typeActivity";
            this.typeActivity.Size = new System.Drawing.Size(101, 21);
            this.typeActivity.TabIndex = 4;
            this.typeActivity.SelectedIndexChanged += new System.EventHandler(this.typeActivity_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.names,
            this.lastName,
            this.cargo,
            this.age,
            this.dateAdmission,
            this.dateRetirement,
            this.photo});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 280);
            this.dataGridView1.TabIndex = 5;
            // 
            // names
            // 
            this.names.Frozen = true;
            this.names.HeaderText = "Nombres";
            this.names.Name = "names";
            this.names.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.Frozen = true;
            this.lastName.HeaderText = "Apellidos";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.Frozen = true;
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 75;
            // 
            // age
            // 
            this.age.Frozen = true;
            this.age.HeaderText = "Edad";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 50;
            // 
            // dateAdmission
            // 
            this.dateAdmission.Frozen = true;
            this.dateAdmission.HeaderText = "Fecha de Ingreso";
            this.dateAdmission.Name = "dateAdmission";
            this.dateAdmission.ReadOnly = true;
            // 
            // dateRetirement
            // 
            this.dateRetirement.Frozen = true;
            this.dateRetirement.HeaderText = "Fecha de Retiro";
            this.dateRetirement.Name = "dateRetirement";
            this.dateRetirement.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.photo.Frozen = true;
            this.photo.HeaderText = "Foto";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.Text = "Sistema Empleado";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Controller.ControlGrid.ControlGrid.ShowCount(
                CountEmployee);
        }

        private void typeActivity_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Controller.ControlGrid.ControlGrid.ShowRegisterByActivity(
                typeActivity.SelectedItem.ToString());
        }

        private void FormularioPrincipal_Load(object sender, System.EventArgs e)
        {
            Controller.ControlGrid.ControlGrid.LoadRegisters();
        }

        private void agregarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AgregarEmpleado().Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new EliminarEmpleado().Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new ActualizarEmpleado().Show();
        }
    }
}
