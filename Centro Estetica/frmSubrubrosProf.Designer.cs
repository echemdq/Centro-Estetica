namespace Centro_Estetica
{
    partial class frmSubrubrosProf
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubrubros = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTraer = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rubro";
            // 
            // cmbRubros
            // 
            this.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubros.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(75, 12);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(197, 21);
            this.cmbRubros.TabIndex = 0;
            this.cmbRubros.SelectedIndexChanged += new System.EventHandler(this.cmbRubros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Subrubro";
            // 
            // cmbSubrubros
            // 
            this.cmbSubrubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubrubros.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmbSubrubros.FormattingEnabled = true;
            this.cmbSubrubros.Location = new System.Drawing.Point(75, 39);
            this.cmbSubrubros.Name = "cmbSubrubros";
            this.cmbSubrubros.Size = new System.Drawing.Size(197, 21);
            this.cmbSubrubros.TabIndex = 1;
            // 
            // btnTraer
            // 
            this.btnTraer.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraer.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Check;
            this.btnTraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraer.Location = new System.Drawing.Point(281, 15);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(41, 38);
            this.btnTraer.TabIndex = 2;
            this.btnTraer.UseVisualStyleBackColor = false;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(307, 158);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Para eliminar doble click sobre la fila deseada";
            // 
            // frmSubrubrosProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubrubros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRubros);
            this.Name = "frmSubrubrosProf";
            this.Text = "frmSubrubrosProf";
            this.Activated += new System.EventHandler(this.frmSubrubrosProf_Activated);
            this.Load += new System.EventHandler(this.frmSubrubrosProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubrubros;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}