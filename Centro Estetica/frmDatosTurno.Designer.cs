namespace Centro_Estetica
{
    partial class frmDatosTurno
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
            this.components = new System.ComponentModel.Container();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarServ = new System.Windows.Forms.Button();
            this.btnEliminarServ = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(88, 81);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(253, 21);
            this.txtProducto.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "Servicios";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(88, 197);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 21);
            this.txtTelefono.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Telefono";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(88, 157);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(253, 21);
            this.txtDetalle.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "Detalle";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(88, 117);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(97, 22);
            this.txtFecha.TabIndex = 106;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtHora
            // 
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(245, 117);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(55, 22);
            this.txtHora.TabIndex = 118;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Fecha";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(88, 47);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(253, 21);
            this.txtPaciente.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Cliente";
            // 
            // txtProfesional
            // 
            this.txtProfesional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesional.Location = new System.Drawing.Point(88, 7);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(253, 21);
            this.txtProfesional.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Profesional";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(208, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 38);
            this.btnGuardar.TabIndex = 112;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarServ
            // 
            this.btnAgregarServ.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarServ.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Add;
            this.btnAgregarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarServ.Enabled = false;
            this.btnAgregarServ.Location = new System.Drawing.Point(404, 70);
            this.btnAgregarServ.Name = "btnAgregarServ";
            this.btnAgregarServ.Size = new System.Drawing.Size(41, 38);
            this.btnAgregarServ.TabIndex = 125;
            this.toolTip1.SetToolTip(this.btnAgregarServ, "Agrega Servicio");
            this.btnAgregarServ.UseVisualStyleBackColor = false;
            this.btnAgregarServ.Click += new System.EventHandler(this.btnAgregarServ_Click);
            // 
            // btnEliminarServ
            // 
            this.btnEliminarServ.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarServ.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Delete;
            this.btnEliminarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarServ.Enabled = false;
            this.btnEliminarServ.Location = new System.Drawing.Point(357, 70);
            this.btnEliminarServ.Name = "btnEliminarServ";
            this.btnEliminarServ.Size = new System.Drawing.Size(41, 38);
            this.btnEliminarServ.TabIndex = 124;
            this.toolTip1.SetToolTip(this.btnEliminarServ, "Elimina Servicio");
            this.btnEliminarServ.UseVisualStyleBackColor = false;
            this.btnEliminarServ.Click += new System.EventHandler(this.btnEliminarServ_Click);
            // 
            // frmDatosTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 291);
            this.Controls.Add(this.btnAgregarServ);
            this.Controls.Add(this.btnEliminarServ);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.label1);
            this.Name = "frmDatosTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatosTurno";
            this.Load += new System.EventHandler(this.frmDatosTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarServ;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEliminarServ;
    }
}