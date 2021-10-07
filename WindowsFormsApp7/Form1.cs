using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int[] a = { 1, 2, 1, 2, 100, 20, 1 };
      int[] b = { 0, 0, 0, 0, 0, 0, 0 };
      imprimir(a, b, 7);
    }
    void imprimir(int[] a, int[] b, int n) //a es arreglo A y b es arreglo B, n es la longitud del arreglo A
    {
      int agregar = 0; //agregar=1 y si no se agrega 0  
                       //a[0]=100 ,a[1]=102 a[2]=80 ,a[3]=102
      int posicionB = 0;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++) //esete ciclo es para recorrre b 
        {
          agregar = 1;
          int a1 = a[i];
          int b1 = b[j];
          if (a1 == b1) //este es para saber si existe en b
          {
            agregar = 0;
            break;
          }
        }
        if (agregar == 1)
        {
          b[posicionB] = a[i];
          int aux = b[posicionB];

          posicionB++;
        }
      }
    }
  }
}
