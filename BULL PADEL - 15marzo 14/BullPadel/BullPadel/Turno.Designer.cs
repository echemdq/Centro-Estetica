namespace BullPadel
{
    partial class Turno
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
            this.j1 = new System.Windows.Forms.Button();
            this.j3 = new System.Windows.Forms.Button();
            this.j4 = new System.Windows.Forms.Button();
            this.j2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // j1
            // 
            this.j1.BackColor = System.Drawing.Color.GreenYellow;
            this.j1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.j1.Location = new System.Drawing.Point(0, 0);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(320, 289);
            this.j1.TabIndex = 0;
            this.j1.Text = "JUGADOR 1";
            this.j1.UseVisualStyleBackColor = false;
            this.j1.Click += new System.EventHandler(this.button1_Click);
            // 
            // j3
            // 
            this.j3.BackColor = System.Drawing.Color.GreenYellow;
            this.j3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.j3.Location = new System.Drawing.Point(0, 288);
            this.j3.Name = "j3";
            this.j3.Size = new System.Drawing.Size(320, 318);
            this.j3.TabIndex = 1;
            this.j3.Text = "JUGADOR 3";
            this.j3.UseVisualStyleBackColor = false;
            this.j3.Click += new System.EventHandler(this.button2_Click);
            // 
            // j4
            // 
            this.j4.BackColor = System.Drawing.Color.GreenYellow;
            this.j4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.j4.Location = new System.Drawing.Point(319, 288);
            this.j4.Name = "j4";
            this.j4.Size = new System.Drawing.Size(320, 318);
            this.j4.TabIndex = 3;
            this.j4.Text = "JUGADOR 4";
            this.j4.UseVisualStyleBackColor = false;
            this.j4.Click += new System.EventHandler(this.button3_Click);
            // 
            // j2
            // 
            this.j2.BackColor = System.Drawing.Color.GreenYellow;
            this.j2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.j2.Location = new System.Drawing.Point(319, 0);
            this.j2.Name = "j2";
            this.j2.Size = new System.Drawing.Size(320, 289);
            this.j2.TabIndex = 2;
            this.j2.Text = "JUGADOR 2";
            this.j2.UseVisualStyleBackColor = false;
            this.j2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BullPadel.Properties.Resources.efectivo;
            this.button1.Location = new System.Drawing.Point(278, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 84);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.j4);
            this.Controls.Add(this.j2);
            this.Controls.Add(this.j3);
            this.Controls.Add(this.j1);
            this.Name = "Turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.Activated += new System.EventHandler(this.Turno_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button j1;
        private System.Windows.Forms.Button j3;
        private System.Windows.Forms.Button j4;
        private System.Windows.Forms.Button j2;
        private System.Windows.Forms.Button button1;

    }
}