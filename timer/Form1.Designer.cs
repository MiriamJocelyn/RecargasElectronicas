namespace timer
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
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.btnInicio = new System.Windows.Forms.Button();
      this.lblTiempo = new System.Windows.Forms.Label();
      this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.SuspendLayout();
      // 
      // timer
      // 
      this.timer.Interval = 1000;
      this.timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // btnInicio
      // 
      this.btnInicio.Location = new System.Drawing.Point(117, 82);
      this.btnInicio.Name = "btnInicio";
      this.btnInicio.Size = new System.Drawing.Size(75, 23);
      this.btnInicio.TabIndex = 0;
      this.btnInicio.Text = "Empezar";
      this.btnInicio.UseVisualStyleBackColor = true;
      this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
      // 
      // lblTiempo
      // 
      this.lblTiempo.AutoSize = true;
      this.lblTiempo.Location = new System.Drawing.Point(124, 62);
      this.lblTiempo.Name = "lblTiempo";
      this.lblTiempo.Size = new System.Drawing.Size(0, 13);
      this.lblTiempo.TabIndex = 1;
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.Path = "C:\\Users\\miris\\Documents\\archivo";
      this.fileSystemWatcher1.SynchronizingObject = this;
      this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Created);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblTiempo);
      this.Controls.Add(this.btnInicio);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Button btnInicio;
    private System.Windows.Forms.Label lblTiempo;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
  }
}

