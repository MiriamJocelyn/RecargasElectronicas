namespace Pruebas.Vista
{
  partial class VAsignacionUsuario
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
      this.gvUsuario = new System.Windows.Forms.DataGridView();
      this.gvReporte = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnTodosIzquierda = new System.Windows.Forms.Button();
      this.btnUnoIzquierda = new System.Windows.Forms.Button();
      this.btnUnoDerecha = new System.Windows.Forms.Button();
      this.btnTodosDerecha = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.gvXAsignar = new System.Windows.Forms.DataGridView();
      this.IdAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporteAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporteAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gvAsignados = new System.Windows.Forms.DataGridView();
      this.IdReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporteAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporteAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvXAsignar)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvAsignados)).BeginInit();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // gvUsuario
      // 
      this.gvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Base,
            this.Usuario,
            this.Nombre});
      this.gvUsuario.ContextMenuStrip = this.menu;
      this.gvUsuario.Location = new System.Drawing.Point(18, 293);
      this.gvUsuario.Name = "gvUsuario";
      this.gvUsuario.Size = new System.Drawing.Size(410, 260);
      this.gvUsuario.TabIndex = 0;
      // 
      // gvReporte
      // 
      this.gvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreReporte,
            this.CategoriaReporte});
      this.gvReporte.Location = new System.Drawing.Point(494, 293);
      this.gvReporte.Name = "gvReporte";
      this.gvReporte.Size = new System.Drawing.Size(418, 260);
      this.gvReporte.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(461, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Reportes";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(141, 267);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(173, 20);
      this.textBox2.TabIndex = 6;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(378, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(173, 21);
      this.comboBox1.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(329, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Usuario";
      // 
      // btnTodosIzquierda
      // 
      this.btnTodosIzquierda.Location = new System.Drawing.Point(422, 52);
      this.btnTodosIzquierda.Name = "btnTodosIzquierda";
      this.btnTodosIzquierda.Size = new System.Drawing.Size(81, 21);
      this.btnTodosIzquierda.TabIndex = 13;
      this.btnTodosIzquierda.Text = "<<";
      this.btnTodosIzquierda.UseVisualStyleBackColor = true;
      this.btnTodosIzquierda.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnUnoIzquierda
      // 
      this.btnUnoIzquierda.Location = new System.Drawing.Point(422, 90);
      this.btnUnoIzquierda.Name = "btnUnoIzquierda";
      this.btnUnoIzquierda.Size = new System.Drawing.Size(81, 21);
      this.btnUnoIzquierda.TabIndex = 14;
      this.btnUnoIzquierda.Text = "<";
      this.btnUnoIzquierda.UseVisualStyleBackColor = true;
      this.btnUnoIzquierda.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnUnoDerecha
      // 
      this.btnUnoDerecha.Location = new System.Drawing.Point(422, 128);
      this.btnUnoDerecha.Name = "btnUnoDerecha";
      this.btnUnoDerecha.Size = new System.Drawing.Size(81, 21);
      this.btnUnoDerecha.TabIndex = 15;
      this.btnUnoDerecha.Text = ">";
      this.btnUnoDerecha.UseVisualStyleBackColor = true;
      this.btnUnoDerecha.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnTodosDerecha
      // 
      this.btnTodosDerecha.Location = new System.Drawing.Point(422, 166);
      this.btnTodosDerecha.Name = "btnTodosDerecha";
      this.btnTodosDerecha.Size = new System.Drawing.Size(81, 21);
      this.btnTodosDerecha.TabIndex = 16;
      this.btnTodosDerecha.Text = ">>";
      this.btnTodosDerecha.UseVisualStyleBackColor = true;
      this.btnTodosDerecha.Click += new System.EventHandler(this.btn_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(378, 219);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(173, 23);
      this.button7.TabIndex = 17;
      this.button7.Text = "Guardar";
      this.button7.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.gvXAsignar);
      this.groupBox1.Location = new System.Drawing.Point(12, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(360, 180);
      this.groupBox1.TabIndex = 20;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "X Asignar";
      // 
      // gvXAsignar
      // 
      this.gvXAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvXAsignar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsignar,
            this.NombreReporteAsignar,
            this.CategoriaReporteAsignar});
      this.gvXAsignar.Location = new System.Drawing.Point(6, 19);
      this.gvXAsignar.Name = "gvXAsignar";
      this.gvXAsignar.ReadOnly = true;
      this.gvXAsignar.Size = new System.Drawing.Size(345, 155);
      this.gvXAsignar.TabIndex = 0;
      // 
      // IdAsignar
      // 
      this.IdAsignar.DataPropertyName = "IdNombre";
      this.IdAsignar.HeaderText = "Id";
      this.IdAsignar.Name = "IdAsignar";
      this.IdAsignar.ReadOnly = true;
      // 
      // NombreReporteAsignar
      // 
      this.NombreReporteAsignar.DataPropertyName = "Nombre";
      this.NombreReporteAsignar.HeaderText = "Nombre Reporte";
      this.NombreReporteAsignar.Name = "NombreReporteAsignar";
      this.NombreReporteAsignar.ReadOnly = true;
      // 
      // CategoriaReporteAsignar
      // 
      this.CategoriaReporteAsignar.DataPropertyName = "Categoria";
      this.CategoriaReporteAsignar.HeaderText = "Categoría Reporte";
      this.CategoriaReporteAsignar.Name = "CategoriaReporteAsignar";
      this.CategoriaReporteAsignar.ReadOnly = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.gvAsignados);
      this.groupBox2.Location = new System.Drawing.Point(552, 32);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(360, 180);
      this.groupBox2.TabIndex = 21;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Asignados";
      // 
      // gvAsignados
      // 
      this.gvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReporte,
            this.NombreReporteAsignados,
            this.CategoriaReporteAsignados});
      this.gvAsignados.Location = new System.Drawing.Point(6, 19);
      this.gvAsignados.Name = "gvAsignados";
      this.gvAsignados.Size = new System.Drawing.Size(345, 155);
      this.gvAsignados.TabIndex = 1;
      // 
      // IdReporte
      // 
      this.IdReporte.DataPropertyName = "IdNombre";
      this.IdReporte.HeaderText = "Id";
      this.IdReporte.Name = "IdReporte";
      this.IdReporte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // NombreReporteAsignados
      // 
      this.NombreReporteAsignados.DataPropertyName = "Nombre";
      this.NombreReporteAsignados.HeaderText = "Nombre Reporte";
      this.NombreReporteAsignados.Name = "NombreReporteAsignados";
      // 
      // CategoriaReporteAsignados
      // 
      this.CategoriaReporteAsignados.DataPropertyName = "Categoria";
      this.CategoriaReporteAsignados.HeaderText = "Categoria Reporte";
      this.CategoriaReporteAsignados.Name = "CategoriaReporteAsignados";
      // 
      // Base
      // 
      this.Base.HeaderText = "Base";
      this.Base.Name = "Base";
      // 
      // Usuario
      // 
      this.Usuario.HeaderText = "Usuario";
      this.Usuario.Name = "Usuario";
      // 
      // Nombre
      // 
      this.Nombre.HeaderText = "Nombre";
      this.Nombre.Name = "Nombre";
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      // 
      // NombreReporte
      // 
      this.NombreReporte.HeaderText = "Nombre Reporte";
      this.NombreReporte.Name = "NombreReporte";
      // 
      // CategoriaReporte
      // 
      this.CategoriaReporte.HeaderText = "Categoría Reporte";
      this.CategoriaReporte.Name = "CategoriaReporte";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(79, 270);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "Usuario";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(576, 274);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 13);
      this.label4.TabIndex = 23;
      this.label4.Text = "Reporte";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(643, 267);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(173, 20);
      this.textBox1.TabIndex = 24;
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
      // 
      // eliminarToolStripMenuItem
      // 
      this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
      this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.eliminarToolStripMenuItem.Text = "Eliminar";
      // 
      // VAsignacionUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(926, 565);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.btnTodosDerecha);
      this.Controls.Add(this.btnUnoDerecha);
      this.Controls.Add(this.btnUnoIzquierda);
      this.Controls.Add(this.btnTodosIzquierda);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.gvReporte);
      this.Controls.Add(this.gvUsuario);
      this.Name = "VAsignacionUsuario";
      this.Text = "Asignaciones por Usuario";
      this.Load += new System.EventHandler(this.VAsignacionUsuario_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvXAsignar)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvAsignados)).EndInit();
      this.menu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView gvUsuario;
    private System.Windows.Forms.DataGridView gvReporte;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnTodosIzquierda;
    private System.Windows.Forms.Button btnUnoIzquierda;
    private System.Windows.Forms.Button btnUnoDerecha;
    private System.Windows.Forms.Button btnTodosDerecha;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView gvXAsignar;
    private System.Windows.Forms.DataGridView gvAsignados;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporteAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporteAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdReporte;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporteAsignados;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporteAsignados;
    private System.Windows.Forms.DataGridViewTextBoxColumn Base;
    private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporte;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporte;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ContextMenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
  }
}