using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      double milla = 1.6093; //milla-kilometro
      double kilometro = 0.631388;//kilometro-milla
      int condicion = Convert.ToInt32(textBox1.Text);
      double numConvertir = Convert.ToDouble(textBox2.Text);
      double resultado = 0;
      if (condicion == 0) //if(condicion>0)
      {
        resultado = numConvertir * kilometro;
      }
      else
      {
        resultado = numConvertir * milla;
      }
      MessageBox.Show(resultado.ToString());
    }
  }
}
