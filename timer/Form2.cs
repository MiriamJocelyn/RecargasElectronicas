using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
  public partial class Form2 : Form
  {
    static System.Timers.Timer tmr = new System.Timers.Timer();
    static int contador = 0;
    static bool repetir = false;
    public Form2()
    {
      InitializeComponent();
      contador = 0;
      tmr.Interval = 1000;
      tmr.Elapsed += tmr_Elapsed;
      tmr.Start();
      repetir = true;
      //System.Threading.Timer timer2 = new System.Threading.Timer(run,null,0,1000);
    }
    static void tmr_Elapsed(object sender, EventArgs e)
    {
      contador++;
      Console.WriteLine("Tick" + contador.ToString());
      Console.WriteLine("Time:" + DateTime.Now.ToLongTimeString());
      if (contador == 60)
        tmr.Dispose();
      Task hiloEscucha = Task.Run(() =>
      {
        Escucha();
      });
      hiloEscucha.Wait();
    }

    static void run(object args)
    {
      Console.WriteLine("Time:" + DateTime.Now.ToLongTimeString());
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      tmr.Dispose();
    }
    public static void Escucha()
    {
      DirectoryInfo di = new DirectoryInfo(@"C:\Users\miris\Documents\archivo");
      if (repetir)
      {
        if (File.Exists(@"C:\Users\miris\Documents\archivo\Respuesta.txt"))
          repetir = false;
        else
        {
          Console.WriteLine("Procesando");
          //Thread.Sleep(3000);
        }
      }
      else
      {
        tmr.Dispose();
        Console.WriteLine("Termino");
      }
    }
  }
}
