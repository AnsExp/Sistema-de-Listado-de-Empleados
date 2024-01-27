using Controller.Controles;
using System.Windows.Forms;

namespace View
{
    internal class EliminarEmpleado : Form
    {
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox tipoDocumento;
        private TextBox numeroDocumento;
        private TableLayoutPanel tableLayoutPanel1;

        public EliminarEmpleado()
        {
            InitializeComponent();
            InitializeListener();
        }

        private readonly ControlEmpleado control = new ControlEmpleado();

        private void InitializeListener()
        {
            control.TipoDocumento = tipoDocumento;
            control.NumeroDocumento = numeroDocumento;
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tipoDocumento, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numeroDocumento, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número Documento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(116, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tipoDocumento.Location = new System.Drawing.Point(116, 3);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(165, 21);
            this.tipoDocumento.TabIndex = 3;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeroDocumento.Location = new System.Drawing.Point(116, 31);
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(165, 20);
            this.numeroDocumento.TabIndex = 4;
            // 
            // EliminarEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarEmpleado";
            this.ShowIcon = false;
            this.Text = "Eliminar Empleado";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            control.DeleteEvent();
        }
    }
}
