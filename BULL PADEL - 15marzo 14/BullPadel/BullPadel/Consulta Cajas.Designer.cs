namespace BullPadel
{
    partial class Consulta_Cajas
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
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ingresotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.egresotxt = new System.Windows.Forms.TextBox();
            this.cajatxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(180, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 33);
            this.comboBox1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "CAJA:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(180, 55);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 33);
            this.maskedTextBox1.TabIndex = 28;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "FECHA:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BullPadel.Properties.Resources.Symbol_Check;
            this.button1.Location = new System.Drawing.Point(198, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(38, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "INGRESOS:";
            // 
            // ingresotxt
            // 
            this.ingresotxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ingresotxt.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresotxt.ForeColor = System.Drawing.Color.DarkRed;
            this.ingresotxt.Location = new System.Drawing.Point(180, 209);
            this.ingresotxt.Multiline = true;
            this.ingresotxt.Name = "ingresotxt";
            this.ingresotxt.ReadOnly = true;
            this.ingresotxt.Size = new System.Drawing.Size(232, 40);
            this.ingresotxt.TabIndex = 35;
            this.ingresotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "EGRESOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "CAJA INICIAL:";
            // 
            // egresotxt
            // 
            this.egresotxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.egresotxt.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egresotxt.ForeColor = System.Drawing.Color.DarkRed;
            this.egresotxt.Location = new System.Drawing.Point(180, 253);
            this.egresotxt.Multiline = true;
            this.egresotxt.Name = "egresotxt";
            this.egresotxt.ReadOnly = true;
            this.egresotxt.Size = new System.Drawing.Size(232, 40);
            this.egresotxt.TabIndex = 32;
            this.egresotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cajatxt
            // 
            this.cajatxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cajatxt.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajatxt.ForeColor = System.Drawing.Color.DarkRed;
            this.cajatxt.Location = new System.Drawing.Point(180, 167);
            this.cajatxt.Multiline = true;
            this.cajatxt.Name = "cajatxt";
            this.cajatxt.ReadOnly = true;
            this.cajatxt.Size = new System.Drawing.Size(232, 40);
            this.cajatxt.TabIndex = 31;
            this.cajatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Consulta_Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 304);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ingresotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.egresotxt);
            this.Controls.Add(this.cajatxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Name = "Consulta_Cajas";
            this.Text = "Consulta_Cajas";
            this.Load += new System.EventHandler(this.Consulta_Cajas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ingresotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox egresotxt;
        private System.Windows.Forms.TextBox cajatxt;
    }
}