﻿namespace Pruebas.Vista
{
  partial class VAccesoReportes
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.asignacionPerfilMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.AsignacionUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionPerfilMenu,
            this.AsignacionUsuarioMenu});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(311, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // asignacionPerfilMenu
      // 
      this.asignacionPerfilMenu.Name = "asignacionPerfilMenu";
      this.asignacionPerfilMenu.Size = new System.Drawing.Size(129, 20);
      this.asignacionPerfilMenu.Text = "Asignación por Perfíl";
      this.asignacionPerfilMenu.Click += new System.EventHandler(this.Menu_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // AsignacionUsuarioMenu
      // 
      this.AsignacionUsuarioMenu.Name = "AsignacionUsuarioMenu";
      this.AsignacionUsuarioMenu.Size = new System.Drawing.Size(142, 20);
      this.AsignacionUsuarioMenu.Text = "Asignación por Usuario";
      this.AsignacionUsuarioMenu.Click += new System.EventHandler(this.Menu_Click);
      // 
      // VAccesoReportes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(311, 34);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "VAccesoReportes";
      this.Text = "VAccesoReportes";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem asignacionPerfilMenu;
    private System.Windows.Forms.ToolStripMenuItem AsignacionUsuarioMenu;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
  }
}