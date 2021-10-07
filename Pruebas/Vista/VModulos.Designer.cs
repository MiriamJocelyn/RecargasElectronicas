namespace Pruebas
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.gvModulo = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.txtId = new System.Windows.Forms.TextBox();
      this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gvModulo)).BeginInit();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // gvModulo
      // 
      this.gvModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion});
      this.gvModulo.ContextMenuStrip = this.menu;
      this.gvModulo.Location = new System.Drawing.Point(12, 148);
      this.gvModulo.Name = "gvModulo";
      this.gvModulo.ReadOnly = true;
      this.gvModulo.Size = new System.Drawing.Size(424, 261);
      this.gvModulo.TabIndex = 1;
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
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(124, 119);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(218, 23);
      this.btnGuardar.TabIndex = 2;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btn_Click);
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(124, 15);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(218, 20);
      this.txtNombre.TabIndex = 5;
      this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(55, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Nombre";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(55, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Descripción";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.Location = new System.Drawing.Point(124, 49);
      this.txtDescripcion.Multiline = true;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(218, 64);
      this.txtDescripcion.TabIndex = 8;
      this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(362, 12);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(45, 20);
      this.txtId.TabIndex = 10;
      this.txtId.Visible = false;
      // 
      // editarToolStripMenuItem
      // 
      this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
      this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.editarToolStripMenuItem.Text = "Editar";
      this.editarToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
      // 
      // eliminarToolStripMenuItem
      // 
      this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
      this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.eliminarToolStripMenuItem.Text = "Eliminar";
      this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
      // 
      // menu
      // 
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
      this.menu.Name = "menu";
      this.menu.Size = new System.Drawing.Size(181, 70);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(448, 417);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.gvModulo);
      this.Name = "Form1";
      this.Text = "Módulos";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvModulo)).EndInit();
      this.menu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView gvModulo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.ContextMenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
  }
}

