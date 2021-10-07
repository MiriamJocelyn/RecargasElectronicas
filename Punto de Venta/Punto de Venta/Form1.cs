using Punto_de_Venta.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class Form1 : Form
    {
        TextBoxEvents evento = new TextBoxEvents();
        public Form1()
        {
            InitializeComponent();
            btnVentas.Enabled = false;
            rbtnIngresoCliente.Select();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            TabSecciones.SelectedIndex = 0;
            BotonesEnable();
            btnVentas.Enabled = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            TabSecciones.SelectedIndex = 1;
            rbtnIngresoCliente.Select();
            txtPagoDeuda.ReadOnly = true;
            BotonesEnable();
            btnClientes.Enabled = false;

        }

        private void rbtnIngresoCliente_CheckedChanged(object sender, EventArgs e)
        {
            ControlLecturaTrue();
            txtPagoDeuda.ReadOnly = true;


        }

        private void rbtnPagoDeudas_CheckedChanged(object sender, EventArgs e)
        {
            ControlesLectura();
            txtPagoDeuda.ReadOnly = false;

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            BotonesEnable();
            btnProductos.Enabled = false;
        }

        private void btnDptoCat_Click(object sender, EventArgs e)
        {
            BotonesEnable();
            btnDptoCat.Enabled = false;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            BotonesEnable();
            btnCompras.Enabled = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            BotonesEnable();
            btnConfig.Enabled = false;
        }

        #region Funciones que permiten los comportamientos del form
        public void ControlesLectura()
        {
            txtNomCom.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtPagoDeuda.ReadOnly = true;
        }
        public void ControlLecturaTrue()
        {
            txtNomCom.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtPagoDeuda.ReadOnly = false;
        }
        public void BotonesEnable()
        {
            btnClientes.Enabled = true;
            btnVentas.Enabled = true;
            btnProductos.Enabled = true;
            btnDptoCat.Enabled = true;
            btnConfig.Enabled = true;
            btnCompras.Enabled = true;
        }




        #endregion

        private void IdTxtChange(object sender, EventArgs e)
        {

        }

        private void IdTxtKeyP(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void NomTxtChange(object sender, EventArgs e)
        {
            
        }

        private void NomTxtKeyP(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void ApeTxtChange(object sender, EventArgs e)
        {

        }

        private void ApeTxtKeyP(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void DirTxtChange(object sender, EventArgs e)
        {

        }

        private void DirTxtKeyP(object sender, KeyPressEventArgs e)
        {

        }

        private void TelTxtChange(object sender, EventArgs e)
        {

        }

        private void TelTxtKeyP(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void PagoTxtChange(object sender, EventArgs e)
        {

        }

        private void PagoTxtKeyP(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(txtPagoDeuda,e);
        }
    }
}
