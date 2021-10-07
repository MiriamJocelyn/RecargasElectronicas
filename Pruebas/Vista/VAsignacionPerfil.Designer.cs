namespace Pruebas.Vista
{
  partial class VAsignacionPerfil
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gvAsignados = new System.Windows.Forms.DataGridView();
      this.IdReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporteAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporteAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.gvXAsignar = new System.Windows.Forms.DataGridView();
      this.IdAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporteAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporteAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button7 = new System.Windows.Forms.Button();
      this.btnTodosDerecha = new System.Windows.Forms.Button();
      this.btnUnoDerecha = new System.Windows.Forms.Button();
      this.btnUnoIzquierda = new System.Windows.Forms.Button();
      this.btnTodosIzquierda = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.gvReporte = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CategoriaReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gvUsuario = new System.Windows.Forms.DataGridView();
      this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvAsignados)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvXAsignar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(641, 267);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(173, 20);
      this.textBox1.TabIndex = 40;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(581, 270);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 13);
      this.label4.TabIndex = 39;
      this.label4.Text = "Reporte";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(77, 270);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 38;
      this.label1.Text = "Usuario";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.gvAsignados);
      this.groupBox2.Location = new System.Drawing.Point(550, 32);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(360, 180);
      this.groupBox2.TabIndex = 37;
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.gvXAsignar);
      this.groupBox1.Location = new System.Drawing.Point(10, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(360, 180);
      this.groupBox1.TabIndex = 36;
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
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(376, 222);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(173, 23);
      this.button7.TabIndex = 35;
      this.button7.Text = "Guardar";
      this.button7.UseVisualStyleBackColor = true;
      // 
      // btnTodosDerecha
      // 
      this.btnTodosDerecha.Location = new System.Drawing.Point(420, 166);
      this.btnTodosDerecha.Name = "btnTodosDerecha";
      this.btnTodosDerecha.Size = new System.Drawing.Size(81, 21);
      this.btnTodosDerecha.TabIndex = 34;
      this.btnTodosDerecha.Text = ">>";
      this.btnTodosDerecha.UseVisualStyleBackColor = true;
      // 
      // btnUnoDerecha
      // 
      this.btnUnoDerecha.Location = new System.Drawing.Point(420, 128);
      this.btnUnoDerecha.Name = "btnUnoDerecha";
      this.btnUnoDerecha.Size = new System.Drawing.Size(81, 21);
      this.btnUnoDerecha.TabIndex = 33;
      this.btnUnoDerecha.Text = ">";
      this.btnUnoDerecha.UseVisualStyleBackColor = true;
      // 
      // btnUnoIzquierda
      // 
      this.btnUnoIzquierda.Location = new System.Drawing.Point(420, 90);
      this.btnUnoIzquierda.Name = "btnUnoIzquierda";
      this.btnUnoIzquierda.Size = new System.Drawing.Size(81, 21);
      this.btnUnoIzquierda.TabIndex = 32;
      this.btnUnoIzquierda.Text = "<";
      this.btnUnoIzquierda.UseVisualStyleBackColor = true;
      // 
      // btnTodosIzquierda
      // 
      this.btnTodosIzquierda.Location = new System.Drawing.Point(420, 52);
      this.btnTodosIzquierda.Name = "btnTodosIzquierda";
      this.btnTodosIzquierda.Size = new System.Drawing.Size(81, 21);
      this.btnTodosIzquierda.TabIndex = 31;
      this.btnTodosIzquierda.Text = "<<";
      this.btnTodosIzquierda.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(327, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 30;
      this.label3.Text = "Usuario";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(376, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(173, 21);
      this.comboBox1.TabIndex = 29;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(459, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 28;
      this.label2.Text = "Reportes";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(139, 267);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(173, 20);
      this.textBox2.TabIndex = 27;
      // 
      // gvReporte
      // 
      this.gvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreReporte,
            this.CategoriaReporte});
      this.gvReporte.Location = new System.Drawing.Point(492, 293);
      this.gvReporte.Name = "gvReporte";
      this.gvReporte.Size = new System.Drawing.Size(418, 260);
      this.gvReporte.TabIndex = 26;
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
      // gvUsuario
      // 
      this.gvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Base,
            this.Usuario,
            this.Nombre});
      this.gvUsuario.Location = new System.Drawing.Point(16, 293);
      this.gvUsuario.Name = "gvUsuario";
      this.gvUsuario.Size = new System.Drawing.Size(410, 260);
      this.gvUsuario.TabIndex = 25;
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
      // VAsignacionPerfil
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(932, 622);
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
      this.Name = "VAsignacionPerfil";
      this.Text = "VAsignacionPerfil";
      this.Load += new System.EventHandler(this.VAsignacionPerfil_Load);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvAsignados)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvXAsignar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView gvAsignados;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdReporte;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporteAsignados;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporteAsignados;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView gvXAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporteAsignar;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporteAsignar;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button btnTodosDerecha;
    private System.Windows.Forms.Button btnUnoDerecha;
    private System.Windows.Forms.Button btnUnoIzquierda;
    private System.Windows.Forms.Button btnTodosIzquierda;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DataGridView gvReporte;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreReporte;
    private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaReporte;
    private System.Windows.Forms.DataGridView gvUsuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn Base;
    private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
  }
}