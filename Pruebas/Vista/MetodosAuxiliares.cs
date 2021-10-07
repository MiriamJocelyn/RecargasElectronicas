using Pruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas.Vista
{
  class MetodosAuxiliares
  {
    public static void DataGridView(DataGridView gv, DataGridViewAutoSizeColumnsMode mode,
           DataGridViewSelectionMode selectionMode = DataGridViewSelectionMode.FullRowSelect)
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      gv.EnableHeadersVisualStyles = false;
      gv.RowHeadersVisible = false;
      gv.AllowUserToAddRows = false;
      gv.AllowUserToDeleteRows = false;
      gv.MultiSelect = false;
      gv.SelectionMode = selectionMode;
      gv.AutoSizeColumnsMode = mode;

    }
    public static void llenarCombo(bool reiniciar, ComboBox combo, string value, string display, object registros)
    {
      if (reiniciar)
        combo.SelectedItem = null;

      combo.ValueMember = value;
      combo.DisplayMember = display;
      combo.DataSource = registros;
    }
    public static void longitudPermitida(TextBox text, KeyPressEventArgs e, int tamano)
    {
      tamano = tamano - 1;
      if (text.Text.Count() > tamano)
        if (e.KeyChar == '\b')
          e.Handled = false;
        else
          e.Handled = true;
      else
        e.Handled = false;
    }

    public static bool PasarAllElementos(DataGridView gvA, DataGridView gvB)
    {

      List<MReporte> lista = new List<MReporte>();
      foreach (DataGridViewRow a in gvA.Rows)
      {
        gvB.Rows.Add(a.Cells[0].Value.ToString(), a.Cells[1].Value.ToString(), a.Cells[2].Value.ToString());
      }

      if (gvA.Rows.Count == 0)
        return false;
      else
      {
        gvA.Rows.Clear();
        
        return true;
      }
    }
    public static bool PasarOneElemento(DataGridView gvA, DataGridView gvB)
    {
      DataGridViewRow row = gvA.CurrentRow;

      if (row!=null)
      {
        gvB.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
        gvA.Rows.RemoveAt(row.Index);
        return true;
      }
      else
        return false;
     
    }

    public static void LimpiarTextBox(Control.ControlCollection controlF)
    {
      foreach (Control cfp in controlF)
      {
        if (cfp is TextBox)
          cfp.Text = "";
          
      }

    }
  }
}
