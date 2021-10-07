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
 
  public partial class VSubModulos : Form
  {
    List<string> errores = new List<string>();
    List<MModulo> modulos = new List<MModulo>();
    public VSubModulos()
    {
      InitializeComponent();
    }

    private void VSubModulos_Load(object sender, EventArgs e)
    {
      MetodosAuxiliares.DataGridView(gvSubModulo, DataGridViewAutoSizeColumnsMode.Fill);
     
      modulos.Add(new MModulo() { Id = 1, Nombre = "Modulo 1", Descripcion = "descripcio 1" });
      modulos.Add(new MModulo() { Id = 2, Nombre = "Modulo 2", Descripcion = "descripcio 2" });
      MetodosAuxiliares.llenarCombo(true, cmbModulo, "Nombre", "Nombre", modulos);
      gvSubModulo.Rows.Add("1", "SubModulo 1", "Descripcion Submodulo", "Modulo 1");
      cmbModulo.SelectedIndex = -1;
    }
    private void MenuItem_Click(object sender, EventArgs e)
    {
      if (sender == editarToolStripMenuItem)
      {
        //MessageBox.Show("Editar");
        Editar();
      }
      if (sender == eliminarToolStripMenuItem)
        MessageBox.Show("Eliminar");
    }
    private void txt_KeyPress(object sender, KeyPressEventArgs e)
    {
      int tamano = 0;
      if (sender == txtNombre)
        tamano = 50;
      else if (sender == txtDescripcion)
        tamano = 250;
      MetodosAuxiliares.longitudPermitida((TextBox)sender, e, tamano);
    }
    public void Guardar()
    {
      errores = new List<string>();
      if (ValidarForm())
      {
        //guardar en la base de datos
        MSubModulo subModulo = ObtenerDatosForm();

        //agregar condicion si no hay ningun error limpiar el form si hay no hacerlo
        LimpiarForm();
      }
      else
      {
        MessageBox.Show(String.Join("\n", errores), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void Editar() {
      txtNombre.Text = gvSubModulo.CurrentRow.Cells[Nombre.Name].Value.ToString();
      txtDescripcion.Text = gvSubModulo.CurrentRow.Cells[Descripcion.Name].Value.ToString();
      txtId.Text = gvSubModulo.CurrentRow.Cells[Id.Name].Value.ToString();
      cmbModulo.SelectedValue = Convert.ToString(modulos.Where(c => c.Nombre == gvSubModulo.CurrentRow.Cells[Modulo.Name].Value.ToString()).Select(c => c.Nombre).FirstOrDefault());
    }

    public bool ValidarForm()
    {
      if (txtNombre.Text == "")
        errores.Add("El campo NOMBRE se encuentra vacío");
      if (txtDescripcion.Text == "")
        errores.Add("El campo DESCRIPCIÓN se encuentra vacío");

      if (errores.Count > 0)
        return false;
      else
        return true;
    }

    public void LimpiarForm()
    {
      MetodosAuxiliares.LimpiarTextBox(Controls);
    
    }

    public MSubModulo ObtenerDatosForm()
    {
      return new MSubModulo()
      {
        Nombre = txtNombre.Text,
        Descripcion = txtDescripcion.Text,
        Id = txtId.Text == "" ? 0 : Convert.ToInt32(txtId.Text),
        Modulo = cmbModulo.SelectedValue.ToString()
      };
    }
  }
}
