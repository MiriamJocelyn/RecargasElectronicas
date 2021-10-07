using Pruebas.Modelo;
using Pruebas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
  public partial class Form1 : Form
  {
    List<string> errores = new List<string>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MetodosAuxiliares.DataGridView(gvModulo, DataGridViewAutoSizeColumnsMode.Fill);
      gvModulo.Rows.Add(1);
      gvModulo.Rows[0].Cells["Id"].Value = "1";
      gvModulo.Rows[0].Cells["Nombre"].Value = "Venta";
      gvModulo.Rows[0].Cells["Descripcion"].Value = "modulo de venta";
    }



    private void MenuItem_Click(object sender, EventArgs e)
    {
      if (sender == editarToolStripMenuItem)
        Editar();
      if (sender == eliminarToolStripMenuItem)
        Eliminar();
      
    }

    private void Txt_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (sender == txtNombre)
        MetodosAuxiliares.longitudPermitida((TextBox)sender, e, 50);
      else if (sender == txtDescripcion)
        MetodosAuxiliares.longitudPermitida((TextBox)sender, e, 250);
    }

    private void btn_Click(object sender, EventArgs e)
    {
      if (sender == btnGuardar)
        Guardar();
    }
    public void Editar()
    {
      txtNombre.Text = gvModulo.CurrentRow.Cells["Nombre"].Value.ToString();
      txtDescripcion.Text = gvModulo.CurrentRow.Cells["Descripcion"].Value.ToString();
      txtId.Text = gvModulo.CurrentRow.Cells["Id"].Value.ToString();
    }

    public void Eliminar() {
      //Revisar si se puede eliminar el módulo, si se puede eliminar preguntarle al usuario si lo desea eliminar

      if (DialogResult.Yes == MessageBox.Show("¿Quieres eliminar el módulo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        MessageBox.Show("djh");
      }
    }
    public void Guardar()
    {
      errores = new List<string>();
      if (ValidarForm())
      {
        //guardar en la base de datos
        MModulo modulo = ObtenerDatosForm();

        //agregar condicion si no hay ningun error limpiar el form si hay no hacerlo
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
      if (txtDescripcion.Text == "")
        errores.Add("El campo DESCRIPCIÓN se encuentra vacío");

      if (errores.Count > 0)
        return false;
      else
        return true;
    }

    public void LimpiarForm()
    {
      txtDescripcion.Text = "";
      txtNombre.Text = "";
      txtId.Text = "";
    }

    public MModulo ObtenerDatosForm()
    {
      return new MModulo()
      {
        Nombre = txtNombre.Text,
        Descripcion = txtDescripcion.Text,
        Id = txtId.Text == "" ? 0 : Convert.ToInt32(txtId.Text)
      };
    }
  }
}
