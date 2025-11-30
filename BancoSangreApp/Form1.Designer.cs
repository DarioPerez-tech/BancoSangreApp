namespace BancoSangreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            TipoSangre = new Label();
            Telefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            cmbTipoSangre = new ComboBox();
            btnRegistrar = new Button();
            dgvDonadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonadores).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(64, 66);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // TipoSangre
            // 
            TipoSangre.AutoSize = true;
            TipoSangre.Location = new Point(64, 159);
            TipoSangre.Name = "TipoSangre";
            TipoSangre.Size = new Size(132, 25);
            TipoSangre.TabIndex = 1;
            TipoSangre.Text = "Tipo de Sangre";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(64, 111);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(79, 25);
            Telefono.TabIndex = 2;
            Telefono.Text = "Telefono";
            Telefono.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(217, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(217, 111);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 4;
            // 
            // cmbTipoSangre
            // 
            cmbTipoSangre.FormattingEnabled = true;
            cmbTipoSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "C++" });
            cmbTipoSangre.Location = new Point(217, 159);
            cmbTipoSangre.Name = "cmbTipoSangre";
            cmbTipoSangre.Size = new Size(182, 33);
            cmbTipoSangre.TabIndex = 5;
            cmbTipoSangre.SelectedIndexChanged += cmbTipoSangre_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(87, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(183, 34);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Donador";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvDonadores
            // 
            dgvDonadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonadores.Location = new Point(554, 35);
            dgvDonadores.Name = "dgvDonadores";
            dgvDonadores.RowHeadersWidth = 62;
            dgvDonadores.Size = new Size(670, 225);
            dgvDonadores.TabIndex = 7;
            dgvDonadores.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 450);
            Controls.Add(dgvDonadores);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTipoSangre);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(Telefono);
            Controls.Add(TipoSangre);
            Controls.Add(Nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label TipoSangre;
        private Label Telefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private ComboBox cmbTipoSangre;
        private Button btnRegistrar;
        private DataGridView dgvDonadores;
    }
}
