namespace Centro_Estetica
{
    partial class frmCursos
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
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cmbProfesionales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtFecha.Location = new System.Drawing.Point(121, 66);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 21);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(121, 12);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidades.TabIndex = 0;
            this.cmbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidades_SelectedIndexChanged);
            // 
            // cmbProfesionales
            // 
            this.cmbProfesionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesionales.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbProfesionales.FormattingEnabled = true;
            this.cmbProfesionales.Location = new System.Drawing.Point(121, 39);
            this.cmbProfesionales.Name = "cmbProfesionales";
            this.cmbProfesionales.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesionales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profesional";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Check;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(292, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Enabled = false;
            this.btnCliente.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnCliente.Location = new System.Drawing.Point(84, 93);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(203, 31);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Carga Cliente y Servicio";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 168);
            this.dataGridView1.TabIndex = 87;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfesionales);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.txtFecha);
            this.MaximumSize = new System.Drawing.Size(409, 357);
            this.MinimumSize = new System.Drawing.Size(409, 357);
            this.Name = "frmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.ComboBox cmbProfesionales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}