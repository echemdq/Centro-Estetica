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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.seguimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTurnoToolStripMenuItem,
            this.toolStripSeparator2,
            this.suspenderTurnoFijoToolStripMenuItem,
            this.liberaTurnoToolStripMenuItem,
            this.toolStripSeparator3,
            this.habilitaHoraToolStripMenuItem,
            this.deshabilitaHoraToolStripMenuItem,
            this.toolStripSeparator1,
            this.seguimientoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 154);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(981, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1010, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Facturacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape5,
            this.ovalShape4,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1235, 419);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape5
            // 
            this.ovalShape5.BackColor = System.Drawing.Color.Blue;
            this.ovalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape5.Location = new System.Drawing.Point(974, 342);
            this.ovalShape5.Name = "ovalShape5";
            this.ovalShape5.Size = new System.Drawing.Size(50, 20);
            // 
            // ovalShape4
            // 
            this.ovalShape4.BackColor = System.Drawing.Color.Green;
            this.ovalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape4.Location = new System.Drawing.Point(974, 370);
            this.ovalShape4.Name = "ovalShape4";
            this.ovalShape4.Size = new System.Drawing.Size(50, 20);
            // 
            // ovalShape3
            // 
            this.ovalShape3.BackColor = System.Drawing.Color.Red;
            this.ovalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape3.Location = new System.Drawing.Point(974, 314);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(50, 20);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BackColor = System.Drawing.Color.LightBlue;
            this.ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape2.Location = new System.Drawing.Point(974, 287);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(50, 20);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.White;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.Location = new System.Drawing.Point(974, 260);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(50, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno Libre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1040, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turno Fijo Suspendido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1040, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turno Fijo Semanal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1040, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turno Fijo Quincenal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Turno Diario";
            // 
            // frmTurnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmTurnero";
            this.Text = "Turnero";
            this.Load += new System.EventHandler(this.frmTurnero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}