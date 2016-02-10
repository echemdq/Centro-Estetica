namespace Centro_Estetica
{
    partial class frmHistorialCliente
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
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.rbAsistidos = new System.Windows.Forms.RadioButton();
            this.rbTurnos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(60, 12);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(253, 21);
            this.txtPaciente.TabIndex = 1;
            // 
            // rbAsistidos
            // 
            this.rbAsistidos.AutoSize = true;
            this.rbAsistidos.Checked = true;
            this.rbAsistidos.Location = new System.Drawing.Point(60, 43);
            this.rbAsistidos.Name = "rbAsistidos";
            this.rbAsistidos.Size = new System.Drawing.Size(102, 17);
            this.rbAsistidos.TabIndex = 2;
            this.rbAsistidos.TabStop = true;
            this.rbAsistidos.Text = "Turnos Asistidos";
            this.rbAsistidos.UseVisualStyleBackColor = true;
            // 
            // rbTurnos
            // 
            this.rbTurnos.AutoSize = true;
            this.rbTurnos.Location = new System.Drawing.Point(210, 43);
            this.rbTurnos.Name = "rbTurnos";
            this.rbTurnos.Size = new System.Drawing.Size(103, 17);
            this.rbTurnos.TabIndex = 3;
            this.rbTurnos.TabStop = true;
            this.rbTurnos.Text = "Todos los turnos";
            this.rbTurnos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente";
            // 
            // btnTraer
            // 
            this.btnTraer.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraer.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Check;
            this.btnTraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraer.Location = new System.Drawing.Point(391, 12);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(41, 38);
            this.btnTraer.TabIndex = 1;
            this.btnTraer.UseVisualStyleBackColor = false;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::Centro_Estetica.Properties.Resources.Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(332, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 302);
            this.dataGridView1.TabIndex = 42;
            // 
            // frmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTurnos);
            this.Controls.Add(this.rbAsistidos);
            this.Controls.Add(this.txtPaciente);
            this.MaximumSize = new System.Drawing.Size(695, 430);
            this.MinimumSize = new System.Drawing.Size(695, 430);
            this.Name = "frmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial del Cliente";
            this.Load += new System.EventHandler(this.frmHistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.RadioButton rbAsistidos;
        private System.Windows.Forms.RadioButton rbTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}