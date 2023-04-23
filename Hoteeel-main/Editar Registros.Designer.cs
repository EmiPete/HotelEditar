namespace HOTEL
{
    partial class Editar_Registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DGVEditar = new DataGridView();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEdad = new TextBox();
            label6 = new Label();
            txtDias = new TextBox();
            label7 = new Label();
            cmboxHab = new ComboBox();
            PanelCampos = new Panel();
            btnActualizar = new Button();
            label8 = new Label();
            DTPDiaEntrada = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGVEditar).BeginInit();
            PanelCampos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 0;
            label1.Text = "Editar Registros";
            // 
            // DGVEditar
            // 
            DGVEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEditar.Location = new Point(41, 129);
            DGVEditar.Name = "DGVEditar";
            DGVEditar.RowTemplate.Height = 25;
            DGVEditar.Size = new Size(748, 296);
            DGVEditar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(212, 239, 223);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 84);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingresa el ID del registro a modificar: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(259, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(212, 239, 223);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 35);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(212, 239, 223);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 77);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 74);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(128, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(212, 239, 223);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(231, 80);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(282, 77);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(212, 239, 223);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(404, 35);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "Días:";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(455, 32);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(212, 239, 223);
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(404, 83);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 12;
            label7.Text = "Habitación";
            // 
            // cmboxHab
            // 
            cmboxHab.FormattingEnabled = true;
            cmboxHab.Items.AddRange(new object[] { "Habitacion sencilla $100", "Habitacion Doble $200", "Habitacion VIP $500", "Habitacion VIP doble $600" });
            cmboxHab.Location = new Point(484, 80);
            cmboxHab.Name = "cmboxHab";
            cmboxHab.Size = new Size(154, 23);
            cmboxHab.TabIndex = 16;
            // 
            // PanelCampos
            // 
            PanelCampos.Controls.Add(DTPDiaEntrada);
            PanelCampos.Controls.Add(label8);
            PanelCampos.Controls.Add(btnActualizar);
            PanelCampos.Controls.Add(txtNombre);
            PanelCampos.Controls.Add(cmboxHab);
            PanelCampos.Controls.Add(label3);
            PanelCampos.Controls.Add(label7);
            PanelCampos.Controls.Add(label4);
            PanelCampos.Controls.Add(txtDias);
            PanelCampos.Controls.Add(txtTelefono);
            PanelCampos.Controls.Add(label6);
            PanelCampos.Controls.Add(label5);
            PanelCampos.Controls.Add(txtEdad);
            PanelCampos.Enabled = false;
            PanelCampos.Location = new Point(41, 431);
            PanelCampos.Name = "PanelCampos";
            PanelCampos.Size = new Size(748, 276);
            PanelCampos.TabIndex = 17;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(615, 27);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 28);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(212, 239, 223);
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 125);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 19;
            label8.Text = "Día de entrada:";
            // 
            // DTPDiaEntrada
            // 
            DTPDiaEntrada.Location = new Point(118, 119);
            DTPDiaEntrada.Name = "DTPDiaEntrada";
            DTPDiaEntrada.Size = new Size(200, 23);
            DTPDiaEntrada.TabIndex = 20;
            // 
            // Editar_Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(947, 736);
            Controls.Add(PanelCampos);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(DGVEditar);
            Controls.Add(label1);
            Name = "Editar_Registros";
            Text = "Editar_Registros";
            Load += Editar_Registros_Load;
            ((System.ComponentModel.ISupportInitialize)DGVEditar).EndInit();
            PanelCampos.ResumeLayout(false);
            PanelCampos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGVEditar;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtEdad;
        private Label label6;
        private TextBox txtDias;
        private Label label7;
        public ComboBox cmboxHab;
        private Panel PanelCampos;
        private Button btnActualizar;
        private DateTimePicker DTPDiaEntrada;
        private Label label8;
    }
}