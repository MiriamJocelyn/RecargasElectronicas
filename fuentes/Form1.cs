using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuentes
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      comboBox1.Items.Clear();
      foreach (FontFamily fuente in FontFamily.Families)
      {
        string name = fuente.Name;
        comboBox1.Items.Add(name);
      }


    }

    private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
    {
      e.DrawBackground();
      string texto = comboBox1.Items[e.Index].ToString();
      Font fuente = new Font(texto, e.Font.Size);
      e.Graphics.DrawString(texto, fuente, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);

      e.DrawFocusRectangle();
    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      comboBox1.Font = new Font(comboBox1.Text, comboBox1.Font.Size);
    }
  }
}
