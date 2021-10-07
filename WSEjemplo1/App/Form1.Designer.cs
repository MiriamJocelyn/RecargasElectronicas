namespace App
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
      this.lblIdentificacion = new System.Windows.Forms.Label();
      this.txtIdentificacion = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblIdentificacion
      // 
      this.lblIdentificacion.AutoSize = true;
      this.lblIdentificacion.Location = new System.Drawing.Point(22, 11);
      this.lblIdentificacion.Name = "lblIdentificacion";
      this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
      this.lblIdentificacion.TabIndex = 0;
      this.lblIdentificacion.Text = "Identificación";
      // 
      // txtIdentificacion
      // 
      this.txtIdentificacion.Location = new System.Drawing.Point(98, 8);
      this.txtIdentificacion.Name = "txtIdentificacion";
      this.txtIdentificacion.Size = new System.Drawing.Size(132, 20);
      this.txtIdentificacion.TabIndex = 1;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(236, 6);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 23);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(48, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Nombre";
      // 
      // txtNombre
      // 
      this.txtNombre.Enabled = false;
      this.txtNombre.Location = new System.Drawing.Point(98, 52);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(132, 20);
      this.txtNombre.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(339, 106);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtIdentificacion);
      this.Controls.Add(this.lblIdentificacion);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblIdentificacion;
    private System.Windows.Forms.TextBox txtIdentificacion;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNombre;
  }
}

