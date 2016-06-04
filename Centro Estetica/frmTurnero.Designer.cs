namespace Centro_Estetica
{
    partial class frmTurnero
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suspenderTurnoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberaTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberaInasistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finTurnoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.seguimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.asignarGabineteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHistCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTurnoToolStripMenuItem,
            this.toolStripSeparator2,
            this.suspenderTurnoFijoToolStripMenuItem,
            this.liberaTurnoToolStripMenuItem,
            this.liberaInasistenciaToolStripMenuItem,
            this.finTurnoFijoToolStripMenuItem,
            this.toolStripSeparator3,
            this.habilitaHoraToolStripMenuItem,
            this.deshabilitaHoraToolStripMenuItem,
            this.toolStripSeparator1,
            this.seguimientoToolStripMenuItem,
            this.toolStripSeparator4,
            this.asignarGabineteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 226);
            // 
            // nuevoTurnoToolStripMenuItem
            // 
            this.nuevoTurnoToolStripMenuItem.Name = "nuevoTurnoToolStripMenuItem";
            this.nuevoTurnoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nuevoTurnoToolStripMenuItem.Text = "Nuevo Turno";
            this.nuevoTurnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoTurnoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // suspenderTurnoFijoToolStripMenuItem
            // 
            this.suspenderTurnoFijoToolStripMenuItem.Name = "suspenderTurnoFijoToolStripMenuItem";
            this.suspenderTurnoFijoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.suspenderTurnoFijoToolStripMenuItem.Text = "Suspender Turno Fijo";
            this.suspenderTurnoFijoToolStripMenuItem.Click += new System.EventHandler(this.suspenderTurnoFijoToolStripMenuItem_Click);
            // 
            // liberaTurnoToolStripMenuItem
            // 
            this.liberaTurnoToolStripMenuItem.Name = "liberaTurnoToolStripMenuItem";
            this.liberaTurnoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.liberaTurnoToolStripMenuItem.Text = "Libera Turno";
            this.liberaTurnoToolStripMenuItem.Click += new System.EventHandler(this.liberaTurnoToolStripMenuItem_Click);
            // 
            // liberaInasistenciaToolStripMenuItem
            // 
            this.liberaInasistenciaToolStripMenuItem.Name = "liberaInasistenciaToolStripMenuItem";
            this.liberaInasistenciaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.liberaInasistenciaToolStripMenuItem.Text = "Libera Inasistencia";
            this.liberaInasistenciaToolStripMenuItem.Click += new System.EventHandler(this.liberaInasistenciaToolStripMenuItem_Click);
            // 
            // finTurnoFijoToolStripMenuItem
            // 
            this.finTurnoFijoToolStripMenuItem.Name = "finTurnoFijoToolStripMenuItem";
            this.finTurnoFijoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.finTurnoFijoToolStripMenuItem.Text = "Fin Turno Fijo";
            this.finTurnoFijoToolStripMenuItem.Click += new System.EventHandler(this.finTurnoFijoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // habilitaHoraToolStripMenuItem
            // 
            this.habilitaHoraToolStripMenuItem.Name = "habilitaHoraToolStripMenuItem";
            this.habilitaHoraToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.habilitaHoraToolStripMenuItem.Text = "Habilita Hora";
            this.habilitaHoraToolStripMenuItem.Click += new System.EventHandler(this.habilitaHoraToolStripMenuItem_Click);
            // 
            // deshabilitaHoraToolStripMenuItem
            // 
            this.deshabilitaHoraToolStripMenuItem.Name = "deshabilitaHoraToolStripMenuItem";
            this.deshabilitaHoraToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deshabilitaHoraToolStripMenuItem.Text = "Deshabilita Hora";
            this.deshabilitaHoraToolStripMenuItem.Click += new System.EventHandler(this.deshabilitaHoraToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // seguimientoToolStripMenuItem
            // 
            this.seguimientoToolStripMenuItem.Name = "seguimientoToolStripMenuItem";
            this.seguimientoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.seguimientoToolStripMenuItem.Text = "Seguimiento";
            this.seguimientoToolStripMenuItem.Click += new System.EventHandler(this.seguimientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // asignarGabineteToolStripMenuItem
            // 
            this.asignarGabineteToolStripMenuItem.Name = "asignarGabineteToolStripMenuItem";
            this.asignarGabineteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.asignarGabineteToolStripMenuItem.Text = "Asignar Gabinete";
            this.asignarGabineteToolStripMenuItem.Click += new System.EventHandler(this.asignarGabineteToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1019, 66);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Facturacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno Libre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turno Fijo Suspendido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turno Fijo Semanal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turno Fijo Quincenal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Turno Diario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(134, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.IndianRed;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(318, 471);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(488, 471);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 23);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Green;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(665, 472);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 23);
            this.textBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(957, 310);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(356, 150);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1010, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista de Espera de Turnos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(981, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Para eliminar doble click sobre la fila deseada";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Orange;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox6.Location = new System.Drawing.Point(795, 472);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 23);
            this.textBox6.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(839, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Asist Confirmada";
            // 
            // btnHistCliente
            // 
            this.btnHistCliente.Location = new System.Drawing.Point(1131, 12);
            this.btnHistCliente.Name = "btnHistCliente";
            this.btnHistCliente.Size = new System.Drawing.Size(182, 42);
            this.btnHistCliente.TabIndex = 89;
            this.btnHistCliente.Text = "Historial Cliente";
            this.btnHistCliente.UseVisualStyleBackColor = true;
            this.btnHistCliente.Click += new System.EventHandler(this.btnHistCliente_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::Centro_Estetica.Properties.Resources.Symbol_Add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1276, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 85;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTurnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 507);
            this.Controls.Add(this.btnHistCliente);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1341, 546);
            this.MinimumSize = new System.Drawing.Size(1341, 546);
            this.Name = "frmTurnero";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnero";
            this.Activated += new System.EventHandler(this.frmTurnero_Activated);
            this.Load += new System.EventHandler(this.frmTurnero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitaHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshabilitaHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderTurnoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem liberaTurnoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem asignarGabineteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHistCliente;
        private System.Windows.Forms.ToolStripMenuItem liberaInasistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finTurnoFijoToolStripMenuItem;
    }
}