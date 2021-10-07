using Pruebas.Modelo;
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
  public partial class VAsignacionUsuario : Form
  {
    public VAsignacionUsuario()
    {
      InitializeComponent();
    }

    private void btn_Click(object sender, EventArgs e)
    {
      if (sender == btnTodosIzquierda)
      {
        if (!MetodosAuxiliares.PasarAllElementos(gvAsignados, gvXAsignar))
          MessageBox.Show("No hay elementos en la lista Asignados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
      else if (sender == btnTodosDerecha)
      {
        if (!MetodosAuxiliares.PasarAllElementos(gvXAsignar, gvAsignados))
          MessageBox.Show("No hay elementos en la lista Asignados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (sender == btnUnoDerecha)
      {
        if (!MetodosAuxiliares.PasarOneElemento(gvXAsignar, gvAsignados))
          MessageBox.Show("No hay ningún elemento seleccionado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (sender == btnUnoIzquierda)
      {
        if (!MetodosAuxiliares.PasarOneElemento(gvAsignados, gvXAsignar))
          MessageBox.Show("No hay ningún elemento seleccionado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void VAsignacionUsuario_Load(object sender, EventArgs e)
    {
      MetodosAuxiliares.DataGridView(gvXAsignar, DataGridViewAutoSizeColumnsMode.Fill);
      MetodosAuxiliares.DataGridView(gvAsignados, DataGridViewAutoSizeColumnsMode.Fill);
      MetodosAuxiliares.DataGridView(gvUsuario, DataGridViewAutoSizeColumnsMode.Fill);
      MetodosAuxiliares.DataGridView(gvReporte, DataGridViewAutoSizeColumnsMode.Fill);

      List<MReporte> mReporte = new List<MReporte>();
      mReporte.Add(new MReporte()
      {
        IdNombre = 2,
        Nombre = "Report 2",
        Categoria = "ACate"
      });
      mReporte.Add(new MReporte()
      {
        IdNombre = 1,
        Nombre = "Report 1",
        Categoria = "BFD"
      });

      foreach (var a in mReporte)
      {
        gvXAsignar.Rows.Add(a.IdNombre, a.Nombre, a.Categoria);
      }
      gvXAsignar.Sort(gvXAsignar.Columns["IdAsignar"], ListSortDirection.Ascending);
      gvXAsignar.Sort(gvXAsignar.Columns["NombreReporteAsignar"], ListSortDirection.Ascending);
      gvXAsignar.Sort(gvXAsignar.Columns["CategoriaReporteAsignar"], ListSortDirection.Ascending);
      //gvXAsignar.DataSource = mReporte;
      //gvXAsignar.Sort(gvXAsignar.Columns["IdNombre"], ListSortDirection.Ascending);

    }

    public void llenar()
    {


    }
  }
}
