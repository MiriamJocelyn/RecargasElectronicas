namespace Pruebas.Vista
{
  partial class VSubModulos
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
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.gvSubModulo = new System.Windows.Forms.DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbModulo = new System.Windows.Forms.ComboBox();
      this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gvSubModulo)).BeginInit();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(354, 10);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(45, 20);
      this.txtId.TabIndex = 17;
      this.txtId.Visible = false;
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.Location = new System.Drawing.Point(116, 44);
      this.txtDescripcion.Multiline = true;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(218, 64);
      this.txtDescripcion.TabIndex = 16;
      this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(47, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 15;
      this.label2.Text = "Descripción";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(66, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Nombre";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(116, 10);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(218, 20);
      this.txtNombre.TabIndex = 13;
      this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(116, 148);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(218, 23);
      this.btnGuardar.TabIndex = 12;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      // 
      // gvSubModulo
      // 
      this.gvSubModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvSubModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.Modulo});
      this.gvSubModulo.ContextMenuStrip = this.menu;
      this.gvSubModulo.Location = new System.Drawing.Point(12, 177);
      this.gvSubModulo.Name = "gvSubModulo";
      this.gvSubModulo.ReadOnly = true;
      this.gvSubModulo.Size = new System.Drawing.Size(424, 261);
      this.gvSubModulo.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(68, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Módulo";
      // 
      // cmbModulo
      // 
      this.cmbModulo.FormattingEnabled = true;
      this.cmbModulo.Location = new System.Drawing.Point(116, 120);
      this.cmbModulo.Name = "cmbModulo";
      this.cmbModulo.Size = new System.Drawing.Size(218, 21);
      this.cmbModulo.TabIndex = 19;
      // 
      // menu
      // 
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
      this.menu.Name = "menu";
      this.menu.Size = new System.Drawing.Size(118, 48);
      // 
      // editarToolStripMenuItem
      // 
      this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
      this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.editarToolStripMenuItem.Text = "Editar";
      this.editarToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
      // 
      // eliminarToolStripMenuItem
      // 
      this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
      this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.eliminarToolStripMenuItem.Text = "Eliminar";
      this.eliminarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuItem_Click);
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      // 
      // Nombre
      // 
      this.Nombre.HeaderText = "Nombre";
      this.Nombre.Name = "Nombre";
      this.Nombre.ReadOnly = true;
      // 
      // Descripcion
      // 
      this.Descripcion.HeaderText = "Descripción";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      // 
      // Modulo
      // 
      this.Modulo.HeaderText = "Módulo";
      this.Modulo.Name = "Modulo";
      this.Modulo.ReadOnly = true;
      // 
      // VSubModulos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 450);
      this.Controls.Add(this.cmbModulo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.gvSubModulo);
      this.Name = "VSubModulos";
      this.Text = "SubMódulos";
      this.Load += new System.EventHandler(this.VSubModulos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvSubModulo)).EndInit();
      this.menu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.DataGridView gvSubModulo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbModulo;
    private System.Windows.Forms.ContextMenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
  }
}