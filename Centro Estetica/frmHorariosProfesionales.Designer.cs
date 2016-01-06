namespace Centro_Estetica
{
    partial class frmHorariosProfesionales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label36 = new System.Windows.Forms.Label();
            this.txtEgr = new System.Windows.Forms.MaskedTextBox();
            this.txtIng = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.TSemana = new System.Windows.Forms.TextBox();
            this.chkSemana = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(134, 172);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(308, 13);
            this.label36.TabIndex = 80;
            this.label36.Text = "Hacer Doble Click sobre la fila que se desea Eliminar";
            // 
            // txtEgr
            // 
            this.txtEgr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgr.Location = new System.Drawing.Point(234, 238);
            this.txtEgr.Mask = "00:00";
            this.txtEgr.Name = "txtEgr";
            this.txtEgr.Size = new System.Drawing.Size(55, 22);
            this.txtEgr.TabIndex = 1;
            this.txtEgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEgr.ValidatingType = typeof(System.DateTime);
            // 
            // txtIng
            // 
            this.txtIng.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIng.Location = new System.Drawing.Point(234, 202);
            this.txtIng.Mask = "00:00";
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(55, 22);
            this.txtIng.TabIndex = 0;
            this.txtIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIng.ValidatingType = typeof(System.DateTime);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(174, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 14);
            this.label22.TabIndex = 83;
            this.label22.Text = "Egreso:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(169, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 14);
            this.label20.TabIndex = 84;
            this.label20.Text = "Ingreso:";
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(234, 279);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(97, 22);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            this.txtDesde.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtDesde_TypeValidationCompleted);
            this.txtDesde.Validated += new System.EventHandler(this.txtDesde_Validated);
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(234, 315);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(97, 22);
            this.txtHasta.TabIndex = 3;
            this.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            this.txtHasta.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtHasta_TypeValidationCompleted);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(84, 317);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(146, 16);
            this.label46.TabIndex = 88;
            this.label46.Text = "Hasta (vacio-activo)";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(182, 281);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(48, 16);
            this.label45.TabIndex = 87;
            this.label45.Text = "Desde";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.checkedListBox1.Location = new System.Drawing.Point(361, 204);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(134, 126);
            this.checkedListBox1.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 172);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 90;
            this.lblId.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(496, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 38);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Enabled = false;
            this.maskedTextBox7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox7.Location = new System.Drawing.Point(442, 350);
            this.maskedTextBox7.Mask = "00/00/0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(97, 22);
            this.maskedTextBox7.TabIndex = 92;
            this.maskedTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.maskedTextBox7, "Ingrese fecha para determinar si la correspondiente semana anualizada es PAR o IM" +
        "PAR");
            this.maskedTextBox7.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox7.Visible = false;
            this.maskedTextBox7.Validated += new System.EventHandler(this.maskedTextBox7_Validated);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(60, 351);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(170, 16);
            this.label43.TabIndex = 93;
            this.label43.Text = "Semana (1-Impar 2-Par)";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // TSemana
            // 
            this.TSemana.Enabled = false;
            this.TSemana.Location = new System.Drawing.Point(236, 350);
            this.TSemana.Name = "TSemana";
            this.TSemana.Size = new System.Drawing.Size(27, 20);
            this.TSemana.TabIndex = 91;
            // 
            // chkSemana
            // 
            this.chkSemana.AutoSize = true;
            this.chkSemana.Checked = true;
            this.chkSemana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSemana.Location = new System.Drawing.Point(269, 352);
            this.chkSemana.Name = "chkSemana";
            this.chkSemana.Size = new System.Drawing.Size(119, 17);
            this.chkSemana.TabIndex = 94;
            this.chkSemana.Text = "Todas las Semanas";
            this.chkSemana.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(496, 217);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 38);
            this.btnEditar.TabIndex = 95;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmHorariosProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 376);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.chkSemana);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.TSemana);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.txtEgr);
            this.Controls.Add(this.txtIng);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHorariosProfesionales";
            this.Text = "frmHorariosProfesionales";
            this.Load += new System.EventHandler(this.frmHorariosProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.MaskedTextBox txtEgr;
        private System.Windows.Forms.MaskedTextBox txtIng;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox TSemana;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.CheckBox chkSemana;
        private System.Windows.Forms.Button btnEditar;
    }
}