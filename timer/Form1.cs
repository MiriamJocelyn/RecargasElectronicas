using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
  public partial class Form1 : Form
  {
    int conteo = 0;
    string nameFile = "";
    bool seCreo = false;
    public Form1()
    {
      InitializeComponent();
    }

    private void BtnInicio_Click(object sender, EventArgs e)
    {
      conteo = 0;

      timer.Start();
      timer.Enabled = true;
      //hiloEscucha.Wait();
      //Console.WriteLine("TErmino");
    }
    public void LecturaArchivo()
    {
      DirectoryInfo di = new DirectoryInfo(@"C:\Users\miris\Documents\archivo");
      foreach (var fi in di.GetFiles())
      {
        if (fi.Name.Contains("Respuesta"))
          timer.Enabled = false;
        Console.WriteLine(fi.Name);
      }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      conteo++;
      lblTiempo.Text = conteo.ToString();
      Task hiloEscucha = Task.Run(() =>
      {
        Escucha();
      });
      hiloEscucha.Wait();
      Console.WriteLine("TErmino");
      //LecturaArchivo();
    }

    private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
    {
      string value = $"Created: {e.FullPath}";
      nameFile = e.Name;
      Console.WriteLine(value);
    }

    public void Escucha()
    {
      bool repetir = true;
      
      //do
      //{
        
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\miris\Documents\archivo");

      if (File.Exists(@"C:\Users\miris\Documents\archivo\Respuesta"))
        repetir = false;
      else
      {
        Console.WriteLine("Procesando");
        //Thread.Sleep(3000);
      }
      //foreach (var fi in di.GetFiles())
      //  {
      //    if (fi.Name.Contains("Respuesta"))
      //      repetir = false;
      //  }
        Console.WriteLine("Procesando");
        if (conteo == 20)
        {
          repetir = false;
          Console.WriteLine("Termino");
          timer.Enabled = false;
        }
      //} while (repetir);
      //Thread.Sleep(3000);

    }
  }
}
