namespace Centro_Estetica
{
    partial class frmNuevoTurno
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarPac = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFijo = new System.Windows.Forms.CheckBox();
            this.rbSemanal = new System.Windows.Forms.RadioButton();
            this.rbQuincenal = new System.Windows.Forms.RadioButton();
            this.label43 = new System.Windows.Forms.Label();
            this.TSemana = new System.Windows.Forms.TextBox();
            this.lblIdProf = new System.Windows.Forms.Label();
            this.lblIdPac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarPac
            // 
            this.btnBuscarPac.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarPac.BackgroundImage = global::Centro_Estetica.Properties.Resources.Search;
            this.btnBuscarPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPac.Location = new System.Drawing.Point(364, 44);
            this.btnBuscarPac.Name = "btnBuscarPac";
            this.btnBuscarPac.Size = new System.Drawing.Size(41, 38);
            this.btnBuscarPac.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnBuscarPac, "Buscar");
            this.btnBuscarPac.UseVisualStyleBackColor = false;
            this.btnBuscarPac.Click += new System.EventHandler(this.btnBuscarPac_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(201, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 38);
            this.btnGuardar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProd.BackgroundImage = global::Centro_Estetica.Properties.Resources.Search;
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProd.Location = new System.Drawing.Point(364, 83);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(41, 38);
            this.btnBuscarProd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBuscarProd, "Buscar");
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(88, 58);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(253, 21);
            this.txtPaciente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hora";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(88, 128);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(97, 22);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.Validated += new System.EventHandler(this.txtFecha_Validated);
            // 
            // txtHora
            // 
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(245, 128);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(55, 22);
            this.txtHora.TabIndex = 74;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(88, 208);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 21);
            this.txtTelefono.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Telefono";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(88, 168);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(253, 21);
            this.txtDetalle.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Detalle";
            // 
            // chkFijo
            // 
            this.chkFijo.AutoSize = true;
            this.chkFijo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.chkFijo.Location = new System.Drawing.Point(88, 247);
            this.chkFijo.Name = "chkFijo";
            this.chkFijo.Size = new System.Drawing.Size(83, 17);
            this.chkFijo.TabIndex = 6;
            this.chkFijo.Text = "Turno Fijo";
            this.chkFijo.UseVisualStyleBackColor = true;
            this.chkFijo.CheckedChanged += new System.EventHandler(this.chkFijo_CheckedChanged);
            // 
            // rbSemanal
            // 
            this.rbSemanal.AutoSize = true;
            this.rbSemanal.Enabled = false;
            this.rbSemanal.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rbSemanal.Location = new System.Drawing.Point(190, 246);
            this.rbSemanal.Name = "rbSemanal";
            this.rbSemanal.Size = new System.Drawing.Size(75, 17);
            this.rbSemanal.TabIndex = 7;
            this.rbSemanal.TabStop = true;
            this.rbSemanal.Text = "Semanal";
            this.rbSemanal.UseVisualStyleBackColor = true;
            // 
            // rbQuincenal
            // 
            this.rbQuincenal.AutoSize = true;
            this.rbQuincenal.Enabled = false;
            this.rbQuincenal.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rbQuincenal.Location = new System.Drawing.Point(281, 246);
            this.rbQuincenal.Name = "rbQuincenal";
            this.rbQuincenal.Size = new System.Drawing.Size(81, 17);
            this.rbQuincenal.TabIndex = 8;
            this.rbQuincenal.TabStop = true;
            this.rbQuincenal.Text = "Quincenal";
            this.rbQuincenal.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(85, 282);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(170, 16);
            this.label43.TabIndex = 98;
            this.label43.Text = "Semana (1-Impar 2-Par)";
            // 
            // TSemana
            // 
            this.TSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSemana.Enabled = false;
            this.TSemana.Location = new System.Drawing.Point(267, 281);
            this.TSemana.Name = "TSemana";
            this.TSemana.Size = new System.Drawing.Size(27, 20);
            this.TSemana.TabIndex = 96;
            // 
            // lblIdProf
            // 
            this.lblIdProf.AutoSize = true;
            this.lblIdProf.Location = new System.Drawing.Point(19, 287);
            this.lblIdProf.Name = "lblIdProf";
            this.lblIdProf.Size = new System.Drawing.Size(0, 13);
            this.lblIdProf.TabIndex = 100;
            this.lblIdProf.Visible = false;
            // 
            // lblIdPac
            // 
            this.lblIdPac.AutoSize = true;
            this.lblIdPac.Location = new System.Drawing.Point(26, 308);
            this.lblIdPac.Name = "lblIdPac";
            this.lblIdPac.Size = new System.Drawing.Size(0, 13);
            this.lblIdPac.TabIndex = 101;
            this.lblIdPac.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Profesional";
            // 
            // txtProfesional
            // 
            this.txtProfesional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesional.Location = new System.Drawing.Point(88, 18);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(253, 21);
            this.txtProfesional.TabIndex = 64;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(88, 92);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(253, 21);
            this.txtProducto.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Producto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(411, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 104;
            this.toolTip1.SetToolTip(this.button1, "Agregar nuevo paciente");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIdPac);
            this.Controls.Add(this.lblIdProf);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.TSemana);
            this.Controls.Add(this.rbQuincenal);
            this.Controls.Add(this.rbSemanal);
            this.Controls.Add(this.chkFijo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPac);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.label1);
            this.Name = "frmNuevoTurno";
            this.Text = "frmNuevoTurno";
            this.Load += new System.EventHandler(this.frmNuevoTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscarPac;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFijo;
        private System.Windows.Forms.RadioButton rbSemanal;
        private System.Windows.Forms.RadioButton rbQuincenal;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox TSemana;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIdProf;
        private System.Windows.Forms.Label lblIdPac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}