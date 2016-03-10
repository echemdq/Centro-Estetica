namespace Centro_Estetica
{
    partial class frmProfesionales
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
            this.btnSubrubros = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubrubros
            // 
            this.btnSubrubros.Enabled = false;
            this.btnSubrubros.Location = new System.Drawing.Point(428, 70);
            this.btnSubrubros.Name = "btnSubrubros";
            this.btnSubrubros.Size = new System.Drawing.Size(75, 44);
            this.btnSubrubros.TabIndex = 65;
            this.btnSubrubros.Text = "Config Subrubros";
            this.toolTip1.SetToolTip(this.btnSubrubros, "Configurar Subrubros del Profesional");
            this.btnSubrubros.UseVisualStyleBackColor = true;
            this.btnSubrubros.Click += new System.EventHandler(this.btnSubrubros_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.Enabled = false;
            this.btnHorarios.Location = new System.Drawing.Point(428, 126);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(75, 44);
            this.btnHorarios.TabIndex = 66;
            this.btnHorarios.Text = "Config Horarios";
            this.toolTip1.SetToolTip(this.btnHorarios, "Configurar Subrubros del Profesional");
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(424, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 38);
            this.btnBuscar.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Centro_Estetica.Properties.Resources.Undo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(328, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 45;
            this.toolTip1.SetToolTip(this.button1, "Limpiar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(281, 206);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 38);
            this.btnEditar.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Recycle_Bin_Full;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(234, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(41, 38);
            this.btnEliminar.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(187, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 38);
            this.btnGuardar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Centro_Estetica.Properties.Resources.Document;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(140, 206);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(41, 38);
            this.btnNuevo.TabIndex = 41;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(428, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 67;
            this.button2.Text = "Honorarios por Excepcion";
            this.toolTip1.SetToolTip(this.button2, "Configurar Subrubros del Profesional");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 213);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 62;
            this.lblId.Visible = false;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(128, 39);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(159, 21);
            this.cmbTipoDoc.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(128, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(253, 21);
            this.txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(128, 127);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 21);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(128, 98);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(253, 21);
            this.txtDomicilio.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(128, 69);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(253, 21);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtProfesional
            // 
            this.txtProfesional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfesional.Enabled = false;
            this.txtProfesional.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesional.Location = new System.Drawing.Point(128, 11);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(253, 21);
            this.txtProfesional.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre y Apellido";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.chkActivo.Location = new System.Drawing.Point(305, 45);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBox1.Location = new System.Drawing.Point(372, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "Sin Turnero";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.Location = new System.Drawing.Point(45, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Especialidad";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.Enabled = false;
            this.cmbEspecialidades.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(128, 181);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(184, 21);
            this.cmbEspecialidades.TabIndex = 74;
            this.cmbEspecialidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEspecialidades_KeyPress);
            // 
            // frmProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 248);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnSubrubros);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.MaximumSize = new System.Drawing.Size(526, 286);
            this.MinimumSize = new System.Drawing.Size(526, 286);
            this.Name = "frmProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Profesionales";
            this.Load += new System.EventHandler(this.frmProfesionales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnSubrubros;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
    }
}