namespace Pruebas.Vista
{
  partial class VReporte
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.cmbCategoria = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbSubModulo = new System.Windows.Forms.ComboBox();
      this.txtEnlace = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEnlacePruebas = new System.Windows.Forms.TextBox();
      this.lblEnlacePruebas = new System.Windows.Forms.Label();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.gvReporte = new System.Windows.Forms.DataGridView();
      this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SubModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EnlaceProductiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EnlacePruebas = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(137, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Categoría";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(147, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Nombre";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(206, 11);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(218, 20);
      this.txtNombre.TabIndex = 9;
      this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // cmbCategoria
      // 
      this.cmbCategoria.FormattingEnabled = true;
      this.cmbCategoria.Location = new System.Drawing.Point(206, 45);
      this.cmbCategoria.Name = "cmbCategoria";
      this.cmbCategoria.Size = new System.Drawing.Size(218, 21);
      this.cmbCategoria.TabIndex = 13;
      this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(130, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "SubMódulo";
      // 
      // cmbSubModulo
      // 
      this.cmbSubModulo.FormattingEnabled = true;
      this.cmbSubModulo.Location = new System.Drawing.Point(206, 76);
      this.cmbSubModulo.Name = "cmbSubModulo";
      this.cmbSubModulo.Size = new System.Drawing.Size(218, 21);
      this.cmbSubModulo.TabIndex = 15;
      // 
      // txtEnlace
      // 
      this.txtEnlace.Location = new System.Drawing.Point(206, 107);
      this.txtEnlace.Name = "txtEnlace";
      this.txtEnlace.Size = new System.Drawing.Size(218, 20);
      this.txtEnlace.TabIndex = 16;
      this.txtEnlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(151, 107);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Enlace";
      // 
      // txtEnlacePruebas
      // 
      this.txtEnlacePruebas.Location = new System.Drawing.Point(206, 137);
      this.txtEnlacePruebas.Name = "txtEnlacePruebas";
      this.txtEnlacePruebas.Size = new System.Drawing.Size(218, 20);
      this.txtEnlacePruebas.TabIndex = 18;
      this.txtEnlacePruebas.Visible = false;
      this.txtEnlacePruebas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // lblEnlacePruebas
      // 
      this.lblEnlacePruebas.AutoSize = true;
      this.lblEnlacePruebas.Location = new System.Drawing.Point(109, 140);
      this.lblEnlacePruebas.Name = "lblEnlacePruebas";
      this.lblEnlacePruebas.Size = new System.Drawing.Size(82, 13);
      this.lblEnlacePruebas.TabIndex = 19;
      this.lblEnlacePruebas.Text = "Enlace Pruebas";
      this.lblEnlacePruebas.Visible = false;
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(206, 163);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(218, 23);
      this.btnGuardar.TabIndex = 20;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btn_Click);
      // 
      // gvReporte
      // 
      this.gvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Categoria,
            this.SubModulo,
            this.EnlaceProductiva,
            this.EnlacePruebas});
      this.gvReporte.ContextMenuStrip = this.menu;
      this.gvReporte.Location = new System.Drawing.Point(12, 195);
      this.gvReporte.Name = "gvReporte";
      this.gvReporte.ReadOnly = true;
      this.gvReporte.Size = new System.Drawing.Size(541, 279);
      this.gvReporte.TabIndex = 21;
      // 
      // menu
      // 
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
      this.menu.Name = "menu";
      this.menu.Size = new System.Drawing.Size(181, 70);
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
      this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.eliminarToolStripMenuItem.Text = "Eliminar";
      this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
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
      // Categoria
      // 
      this.Categoria.HeaderText = "Categoria";
      this.Categoria.Name = "Categoria";
      this.Categoria.ReadOnly = true;
      // 
      // SubModulo
      // 
      this.SubModulo.HeaderText = "SubMódulo";
      this.SubModulo.Name = "SubModulo";
      this.SubModulo.ReadOnly = true;
      // 
      // EnlaceProductiva
      // 
      this.EnlaceProductiva.HeaderText = "Enlace";
      this.EnlaceProductiva.Name = "EnlaceProductiva";
      this.EnlaceProductiva.ReadOnly = true;
      // 
      // EnlacePruebas
      // 
      this.EnlacePruebas.HeaderText = "Enlace Pruebas";
      this.EnlacePruebas.Name = "EnlacePruebas";
      this.EnlacePruebas.ReadOnly = true;
      // 
      // VReporte
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 483);
      this.Controls.Add(this.gvReporte);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.lblEnlacePruebas);
      this.Controls.Add(this.txtEnlacePruebas);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtEnlace);
      this.Controls.Add(this.cmbSubModulo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cmbCategoria);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNombre);
      this.Name = "VReporte";
      this.Text = "Reportes";
      this.Load += new System.EventHandler(this.VReporte_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
      this.menu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.ComboBox cmbCategoria;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbSubModulo;
    private System.Windows.Forms.TextBox txtEnlace;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtEnlacePruebas;
    private System.Windows.Forms.Label lblEnlacePruebas;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.DataGridView gvReporte;
    private System.Windows.Forms.ContextMenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    private System.Windows.Forms.DataGridViewTextBoxColumn SubModulo;
    private System.Windows.Forms.DataGridViewTextBoxColumn EnlaceProductiva;
    private System.Windows.Forms.DataGridViewTextBoxColumn EnlacePruebas;
  }
}