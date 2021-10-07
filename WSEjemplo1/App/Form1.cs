using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      var identificacion = txtIdentificacion.Text;
      using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
      {
        var persona = client.ObtenerPersona(identificacion);
        var nombre = persona.Nombre;
        txtNombre.Text = nombre;
        if (persona.Error != "")
          MessageBox.Show(persona.Error);
      }
    }
  }
}
