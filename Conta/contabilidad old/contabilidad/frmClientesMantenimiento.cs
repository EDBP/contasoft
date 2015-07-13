using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verduras
{
    public partial class frmClientesMantenimiento : Form
    {
      
        public frmClientesMantenimiento()
        {
            InitializeComponent();
            
        }
        public frmClientesMantenimiento(DataRow datos_cliente)
        {
            InitializeComponent();
            txtCodigo.Text = datos_cliente.ItemArray[0].ToString();
            txtNit.Text = datos_cliente.ItemArray[1].ToString();
            txtEmpresa.Text = datos_cliente.ItemArray[2].ToString();
            txtDireccion.Text = datos_cliente.ItemArray[3].ToString();                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar Cambios")
            {
                guardarcambios();
            }
            else
            {
                guardarNuevo();
            }
        }
        private void guardarcambios()
        {
            try
            {
                string telefono = txtTel.Text;
                if (telefono == "")
                    telefono = "0";
                string guardar = "UPDATE empresa SET em_nit='" +
                    txtNit.Text + "',em_nombre='" +
                    txtEmpresa.Text + "',em_direccion='" +
                    txtDireccion.Text + "',em_telefono='" + telefono
                    + "',em_responsable='" + txtResponsable.Text
                    + "',em_fecha_ingres='" + fechaIngreso.DateTime.Date  
                    + "' WHERE em_codigo= " + int.Parse(txtCodigo.Text);
                
                conexion.fnEjecutarComando(guardar);
                MessageBox.Show("Cliente modificado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
            frmClientes.DefInstance.actualizar();
            Close();
        }
        private void guardarNuevo()
        {
            string telefono = txtTel.Text;
            if (telefono == "")
                telefono = "0";
            string guardar = "INSERT INTO empresa(em_codigo,em_nombre, em_nit,em_direccion, em_telefono, em_responsable, em_fecha_ingreso) " +
                "VALUES(" + txtCodigo.Text +
                ",'" + txtEmpresa.Text +
                ",'" + txtNit.Text +                
                "','" + txtDireccion.Text +
                "','" + txtTel.Text +
                "','" + txtResponsable.Text +
                "','" + fechaIngreso.DateTime.Date + "')";
            conexion.fnEjecutarComando(guardar);
            frmClientes.DefInstance.actualizar();
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientesMantenimiento_Activated(object sender, EventArgs e)
        {
            if (this.Text == "Editar Cliente")
            {
                btnGuardar.Text = "Guardar Cambios";
            }
            else
            {
                btnGuardar.Text = "Guardar Nuevo";
            }
        }
        private void EnviarTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }      
        
    }
}
