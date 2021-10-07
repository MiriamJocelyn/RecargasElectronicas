using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      //PrintPDF();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      PrintDocument printDoc = new PrintDocument();

      PrintDocument doc = new PrintDocument()
      {
        PrinterSettings = new PrinterSettings()
        {
          PrinterName = printDoc.PrinterSettings.PrinterName,
          PrintToFile = true,
          PrintFileName = Path.Combine("prueba.pdf")
        }
      };
      doc.Print();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Document doc = new Document(PageSize.LETTER);
      // Indicamos donde vamos a guardar el documento
      PdfWriter writer = PdfWriter.GetInstance(doc,
                                  new FileStream("prueba.pdf", FileMode.Create));

      // Abrimos el archivo
      doc.Open();
      PdfPCell cel = new PdfPCell();

      dataGridView1.Rows.Add("holi");
      DibujarTabla(100, 150, "Arial", Convert.ToSingle(15),2,5);
    }


    public void DibujarTabla(double ancho, double alto, string fuente, float tamanoLetra, int Columanas, int Filas)
    {
      DataGridView gv = new DataGridView();
      gv.RowHeadersVisible = false;
      gv.ColumnHeadersVisible = false;
      gv.AllowUserToAddRows = false;
      gv.ReadOnly = true;
      DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
      gv.Size = new Size(266,19);
      gv.DefaultCellStyle = DefaultStyle(fuente, tamanoLetra);
      gv.Columns.Add(column);

      for (int i = 0; i < Filas; i++)
        gv.Rows.Add();


      //gv.Rows.Add("Hola");
      gv.BackgroundColor = System.Drawing.SystemColors.Control;
      gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
      gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      pPrincipal.Controls.Add(gv);

    }
    public DataGridViewCellStyle DefaultStyle(string Fuente, float TamanoLetra)
    {
      System.Windows.Forms.DataGridViewCellStyle CellStyle = new System.Windows.Forms.DataGridViewCellStyle();
      CellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      CellStyle.BackColor = System.Drawing.SystemColors.Control;
      CellStyle.Font = new System.Drawing.Font(Fuente, TamanoLetra, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      CellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
      CellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
      CellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
      CellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      return CellStyle;
    }


    public static void PrintPDF()
    {
      Process process = new Process();
      process.StartInfo.FileName = "prueba.pdf";
      process.StartInfo.Verb = "printto";

      process.Start();

      // I have to use this in case of Adobe Reader to close the window

      process.WaitForInputIdle();
      process.Kill();
    }
    private void gv_KeyPress(object sender, KeyPressEventArgs e)
    {
      DataGridViewTextBoxEditingControl cargoA = (DataGridViewTextBoxEditingControl)sender;
      string c = "";

      if (e.KeyChar == 13)

      {
        MessageBox.Show("Entro");
      }

      //if (cargoA.Text.Count() > 24)
      //    if (e.KeyChar == '\b')
      //        e.Handled = false;
      //    else
      //        e.Handled = true;
      //else
      //    e.Handled = false;

    }

    private void DataGridView1_EditModeChanged(object sender, EventArgs e)
    {

    }

    private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      e.Control.KeyPress -= new KeyPressEventHandler(gv_KeyPress);
      //e.Control.KeyDown -= new KeyEventHandler(gv_KeyUp);
      TextBox tb = e.Control as TextBox;


      if (tb != null)
      {
        tb.KeyPress += new KeyPressEventHandler(gv_KeyPress);
        //tb.KeyDown += new KeyEventHandler(gv_KeyUp);
      }
    }
  }
}
