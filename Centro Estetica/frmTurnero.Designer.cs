﻿namespace Centro_Estetica
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
            this.habilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.seguimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.habilitaHoraToolStripMenuItem,
            this.deshabilitaHoraToolStripMenuItem,
            this.seguimientoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 114);
            // 
            // nuevoTurnoToolStripMenuItem
            // 
            this.nuevoTurnoToolStripMenuItem.Name = "nuevoTurnoToolStripMenuItem";
            this.nuevoTurnoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoTurnoToolStripMenuItem.Text = "Nuevo Turno";
            this.nuevoTurnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoTurnoToolStripMenuItem_Click);
            // 
            // habilitaHoraToolStripMenuItem
            // 
            this.habilitaHoraToolStripMenuItem.Name = "habilitaHoraToolStripMenuItem";
            this.habilitaHoraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.habilitaHoraToolStripMenuItem.Text = "Habilita Hora";
            this.habilitaHoraToolStripMenuItem.Click += new System.EventHandler(this.habilitaHoraToolStripMenuItem_Click);
            // 
            // deshabilitaHoraToolStripMenuItem
            // 
            this.deshabilitaHoraToolStripMenuItem.Name = "deshabilitaHoraToolStripMenuItem";
            this.deshabilitaHoraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deshabilitaHoraToolStripMenuItem.Text = "Deshabilita Hora";
            this.deshabilitaHoraToolStripMenuItem.Click += new System.EventHandler(this.deshabilitaHoraToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(981, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // seguimientoToolStripMenuItem
            // 
            this.seguimientoToolStripMenuItem.Name = "seguimientoToolStripMenuItem";
            this.seguimientoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.seguimientoToolStripMenuItem.Text = "Seguimiento";
            this.seguimientoToolStripMenuItem.Click += new System.EventHandler(this.seguimientoToolStripMenuItem_Click);
            // 
            // frmTurnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 419);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTurnero";
            this.Text = "frmTurnero";
            this.Load += new System.EventHandler(this.frmTurnero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

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
    }
}