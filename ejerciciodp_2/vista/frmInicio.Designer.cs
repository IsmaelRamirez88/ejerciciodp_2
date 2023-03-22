namespace ejerciciodp_2.vista
{
    partial class frmInicio
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
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.gbPersona = new System.Windows.Forms.GroupBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbDistribuidor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDistribuido = new System.Windows.Forms.TextBox();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbDireccion.SuspendLayout();
            this.gbPersona.SuspendLayout();
            this.gbDistribuidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.txtColonia);
            this.gbDireccion.Controls.Add(this.txtNumero);
            this.gbDireccion.Controls.Add(this.label5);
            this.gbDireccion.Controls.Add(this.label6);
            this.gbDireccion.Controls.Add(this.label9);
            this.gbDireccion.Controls.Add(this.txtCalle);
            this.gbDireccion.Location = new System.Drawing.Point(272, 72);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(260, 135);
            this.gbDireccion.TabIndex = 2;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Direccion";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(71, 78);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 22);
            this.txtColonia.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(71, 51);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Colonia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(71, 25);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 22);
            this.txtCalle.TabIndex = 7;
            // 
            // gbPersona
            // 
            this.gbPersona.Controls.Add(this.txtApellidoMaterno);
            this.gbPersona.Controls.Add(this.txtApellidoPaterno);
            this.gbPersona.Controls.Add(this.label4);
            this.gbPersona.Controls.Add(this.label3);
            this.gbPersona.Controls.Add(this.label2);
            this.gbPersona.Controls.Add(this.txtNombre);
            this.gbPersona.Location = new System.Drawing.Point(6, 72);
            this.gbPersona.Name = "gbPersona";
            this.gbPersona.Size = new System.Drawing.Size(260, 135);
            this.gbPersona.TabIndex = 1;
            this.gbPersona.TabStop = false;
            this.gbPersona.Text = "Persona";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(125, 75);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoMaterno.TabIndex = 5;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(125, 48);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoPaterno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // gbDistribuidor
            // 
            this.gbDistribuidor.Controls.Add(this.label1);
            this.gbDistribuidor.Controls.Add(this.txtIdDistribuido);
            this.gbDistribuidor.Location = new System.Drawing.Point(6, 6);
            this.gbDistribuidor.Name = "gbDistribuidor";
            this.gbDistribuidor.Size = new System.Drawing.Size(260, 60);
            this.gbDistribuidor.TabIndex = 0;
            this.gbDistribuidor.TabStop = false;
            this.gbDistribuidor.Text = "Distribuidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtIdDistribuido
            // 
            this.txtIdDistribuido.Location = new System.Drawing.Point(125, 21);
            this.txtIdDistribuido.Name = "txtIdDistribuido";
            this.txtIdDistribuido.ReadOnly = true;
            this.txtIdDistribuido.Size = new System.Drawing.Size(100, 22);
            this.txtIdDistribuido.TabIndex = 0;
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.AllowUserToAddRows = false;
            this.dgvInformacion.AllowUserToDeleteRows = false;
            this.dgvInformacion.AllowUserToResizeColumns = false;
            this.dgvInformacion.AllowUserToResizeRows = false;
            this.dgvInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInformacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(6, 213);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.RowHeadersVisible = false;
            this.dgvInformacion.RowHeadersWidth = 51;
            this.dgvInformacion.RowTemplate.Height = 24;
            this.dgvInformacion.Size = new System.Drawing.Size(696, 273);
            this.dgvInformacion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(442, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(577, 501);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 40);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 557);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.gbPersona);
            this.Controls.Add(this.gbDistribuidor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 604);
            this.MinimumSize = new System.Drawing.Size(728, 604);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio -- Distribuidor";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.gbPersona.ResumeLayout(false);
            this.gbPersona.PerformLayout();
            this.gbDistribuidor.ResumeLayout(false);
            this.gbDistribuidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.GroupBox gbPersona;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbDistribuidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDistribuido;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
    }
}