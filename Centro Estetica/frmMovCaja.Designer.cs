namespace Centro_Estetica
{
    partial class frmMovCaja
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbrubro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTraer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.comboBox1.Location = new System.Drawing.Point(94, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimiento";
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(94, 90);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(75, 21);
            this.txtPrecioV.TabIndex = 70;
            this.txtPrecioV.Text = "0.00";
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(47, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Rubro";
            // 
            // cmbrubro
            // 
            this.cmbrubro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbrubro.FormattingEnabled = true;
            this.cmbrubro.Location = new System.Drawing.Point(94, 38);
            this.cmbrubro.Name = "cmbrubro";
            this.cmbrubro.Size = new System.Drawing.Size(184, 21);
            this.cmbrubro.TabIndex = 72;
            this.cmbrubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbrubro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(41, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Detalle";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(94, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 21);
            this.textBox1.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 140);
            this.dataGridView1.TabIndex = 76;
            // 
            // btnTraer
            // 
            this.btnTraer.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraer.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Check;
            this.btnTraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraer.Location = new System.Drawing.Point(316, 79);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(41, 38);
            this.btnTraer.TabIndex = 77;
            this.btnTraer.UseVisualStyleBackColor = false;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Doble Click sobre la fila que se desea eliminar";
            // 
            // frmMovCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbrubro);
            this.Controls.Add(this.txtPrecioV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximumSize = new System.Drawing.Size(586, 338);
            this.MinimumSize = new System.Drawing.Size(586, 338);
            this.Name = "frmMovCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de Caja";
            this.Load += new System.EventHandler(this.frmMovCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbrubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Label label4;
    }
}