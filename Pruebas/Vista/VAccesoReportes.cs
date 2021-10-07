using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas.Vista
{
  public partial class VAccesoReportes : Form
  {
    public VAccesoReportes()
    {
      InitializeComponent();
    }

    private void Menu_Click(object sender, EventArgs e)
    {
      if (sender == AsignacionUsuarioMenu)
      {
        VAsignacionUsuario vAsignacion = new VAsignacionUsuario();
        vAsignacion.ShowDialog();
      }
      else if (sender == asignacionPerfilMenu)
      {
        VAsignacionPerfil vAsignacion = new VAsignacionPerfil();
        vAsignacion.ShowDialog();
      }

    }
  }
}
