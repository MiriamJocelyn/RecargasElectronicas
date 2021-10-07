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
  public partial class VReporte : Form
  {
    List<MPropiedad> categorias = new List<MPropiedad>();
    List<MSubModulo> subModulos = new List<MSubModulo>();
    bool primeraVez = true;
    List<string> errores = new List<string>();
    public VReporte()
    {
      InitializeComponent();
    }

    private void txt_KeyPress(object sender, KeyPressEventArgs e)
    {
      int tamano = 0;
      if (sender == txtNombre)
        tamano = 50;
      else if (sender == txtEnlace)
        tamano = 255;
      else if (sender == txtEnlacePruebas)
        tamano = 255;
      MetodosAuxiliares.longitudPermitida((TextBox)sender, e, tamano);
    }

    private void VReporte_Load(object sender, EventArgs e)
    {
      MetodosAuxiliares.DataGridView(gvReporte, DataGridViewAutoSizeColumnsMode.Fill);
      categorias.Add(new MPropiedad() { Id = "PBI", Nombre = "PBI" });
      categorias.Add(new MPropiedad() { Id = "SSRS", Nombre = "SSRS" });

      primeraVez = true;
      MetodosAuxiliares.llenarCombo(true, cmbCategoria, "Nombre", "Nombre", categorias);
      primeraVez = false;
      cmbCategoria.SelectedIndex = -1;
      gvReporte.Rows.Add("1", "Reporte 1", "PBI", "SubModulo", "ENlace ", "Enlace Prueba");
      gvReporte.Rows.Add("2", "Reporte 1", "SSRS", "SubModulo", "E", "");

      subModulos.Add(new MSubModulo() { Id = 1, Nombre = "SubModulo" });
      MetodosAuxiliares.llenarCombo(true, cmbSubModulo, "Nombre", "Nombre", subModulos);
      cmbSubModulo.SelectedIndex = -1;
    }
    private void MenuItem_Click(object sender, EventArgs e)
    {
      if (sender == editarToolStripMenuItem)
        Editar();
      if (sender == eliminarToolStripMenuItem)
        Eliminar();
    }

    private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!primeraVez)
      {
        if (cmbCategoria.SelectedIndex > -1)
        {
          if (cmbCategoria.SelectedValue.ToString().ToUpper() == "PBI")
          {
            txtEnlacePruebas.Visible = true;
            lblEnlacePruebas.Visible = true;
          }
          else if (cmbCategoria.SelectedValue.ToString().ToUpper() == "SSRS")
          {
            txtEnlacePruebas.Visible = false;
            lblEnlacePruebas.Visible = false;
          }
        }
      }
    }

    private void btn_Click(object sender, EventArgs e)
    {
      if (sender == btnGuardar)
        Guardar();
    }

    public void Guardar()
    {
      errores = new List<string>();

      if (ValidarForm())
      {
        //Siempre y cuando el guardado de los datos sea efectivo se limpiara el formulario
         LimpiarForm();
      }
      else
      {
        MessageBox.Show(String.Join("\n", errores), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public bool ValidarForm()
    {
      if (txtNombre.Text == "")
        errores.Add("El campo NOMBRE se encuentra vacío");
      if (cmbCategoria.SelectedIndex < 0)
        errores.Add("El campo CATEGORÍA se encuentra vacío");
      if (cmbSubModulo.SelectedIndex < 0)
        errores.Add("El campo SUBMÓDULO se encuentra vacío");
      if (txtEnlace.Text == "")
        errores.Add("El campo ENLACE se encuentra vacío");

      if (errores.Count > 0)
        return false;
      else
        return true;
    }

    public void LimpiarForm()
    {
      MetodosAuxiliares.LimpiarTextBox(Controls);
      cmbCategoria.SelectedIndex = -1;
      cmbSubModulo.SelectedIndex = -1;
    }

    public void Editar() {
      DataGridViewRow row = new DataGridViewRow();
      row = gvReporte.CurrentRow;
      txtNombre.Text = row.Cells[Nombre.Name].Value.ToString();
      cmbCategoria.SelectedValue = Convert.ToString(categorias.Where(c => c.Nombre == row.Cells[Categoria.Name].Value.ToString()).Select(c => c.Nombre).FirstOrDefault());
      var a = Convert.ToString(subModulos.Where(c => c.Nombre == row.Cells[SubModulo.Name].Value.ToString()).Select(c => c.Nombre).FirstOrDefault()); 
      cmbSubModulo.SelectedValue= Convert.ToString(subModulos.Where(c => c.Nombre == row.Cells[SubModulo.Name].Value.ToString()).Select(c => c.Nombre).FirstOrDefault());
      txtEnlace.Text = row.Cells[EnlaceProductiva.Name].Value.ToString();
      txtEnlacePruebas.Text = row.Cells[EnlacePruebas.Name].Value.ToString();
    }
    public void Eliminar()
    {
      //Revisar si se puede eliminar el reporte, si se puede eliminar preguntarle al usuario si lo desea eliminar

      if (DialogResult.Yes == MessageBox.Show("¿Quieres eliminar el módulo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        MessageBox.Show("djh");
      }
    }
  }
}
