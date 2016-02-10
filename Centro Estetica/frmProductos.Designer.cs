namespace Centro_Estetica
{
    partial class frmProductos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSesiones = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(432, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 38);
            this.btnBuscar.TabIndex = 73;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Centro_Estetica.Properties.Resources.Undo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(332, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 64;
            this.toolTip1.SetToolTip(this.button1, "Limpiar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(285, 183);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 38);
            this.btnEditar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Recycle_Bin_Full;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(238, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(41, 38);
            this.btnEliminar.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(191, 183);
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
            this.btnNuevo.Location = new System.Drawing.Point(144, 183);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(41, 38);
            this.btnNuevo.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.chkActivo.Location = new System.Drawing.Point(332, 66);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioC.Enabled = false;
            this.txtPrecioC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioC.Location = new System.Drawing.Point(155, 149);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(75, 21);
            this.txtPrecioC.TabIndex = 5;
            this.txtPrecioC.Text = "0.00";
            this.txtPrecioC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioC_KeyPress);
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioV.Enabled = false;
            this.txtPrecioV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(155, 122);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(75, 21);
            this.txtPrecioV.TabIndex = 4;
            this.txtPrecioV.Text = "0.00";
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(155, 36);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(253, 21);
            this.txtProducto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "% Calculo Honorario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Precio Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Sesiones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Detalle";
            // 
            // txtSesiones
            // 
            this.txtSesiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSesiones.Enabled = false;
            this.txtSesiones.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtSesiones.Location = new System.Drawing.Point(155, 64);
            this.txtSesiones.Name = "txtSesiones";
            this.txtSesiones.Size = new System.Drawing.Size(42, 21);
            this.txtSesiones.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtStock.HideSelection = false;
            this.txtStock.Location = new System.Drawing.Point(155, 91);
            this.txtStock.Mask = "99999";
            this.txtStock.Name = "txtStock";
            this.txtStock.PromptChar = ' ';
            this.txtStock.Size = new System.Drawing.Size(43, 21);
            this.txtStock.TabIndex = 3;
            this.txtStock.Text = "0";
            this.txtStock.ValidatingType = typeof(int);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 188);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 74;
            this.lblId.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Codigo";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(415, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 49);
            this.button2.TabIndex = 77;
            this.button2.Text = "Excepcion Honorarios Profesionales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtSesiones);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtPrecioC);
            this.Controls.Add(this.txtPrecioV);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.MaximumSize = new System.Drawing.Size(526, 278);
            this.MinimumSize = new System.Drawing.Size(526, 278);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Productos";
            ((System.ComponentModel.ISupportInitialize)(this.txtSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtPrecioC;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.NumericUpDown txtSesiones;
        private System.Windows.Forms.MaskedTextBox txtStock;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}