using contabilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contabilidad
{
    public partial class frmClientesMantenimiento : Form
    {
        Form padre;
        public frmClientesMantenimiento(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
            if (btnGuardar.Text == "Guardar Cambios")
                txtCodigo.Enabled = false;
            else
                txtCodigo.Enabled = true;
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
            string fechaI = fechaIngreso.DateTime.Date.Year.ToString() + "/" + fechaIngreso.DateTime.Date.Month.ToString() + "/" + fechaIngreso.DateTime.Date.Day.ToString();
            try
            {
                string guardar = "UPDATE empresa SET em_nombre='" +
                    txtEmpresa.Text + "',em_nit='" +
                    txtNit.Text + "',em_direccion='" +
                    txtDireccion.Text + "',em_telefono='" + txtTel.Text
                    + "',em_fecha_ingreso='" + fechaI 
                    + "',us_codigo= " + frmPrincipal.usuario
                    + " WHERE em_codigo= " + int.Parse(txtCodigo.Text);

                conexion.fnEjecutarComando(guardar);
                MessageBox.Show("Cliente modificado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
        }
        private void guardarNuevo()
        {
            //String.Format("{0:M/d/yyyy}", dt);
            string fechaI = fechaIngreso.DateTime.Date.Year.ToString() + "/" + fechaIngreso.DateTime.Date.Month.ToString() + "/" + fechaIngreso.DateTime.Date.Day.ToString();
            string fPerIni = fechaIni.DateTime.Date.Year.ToString() + "/" + fechaIni.DateTime.Date.Month.ToString() + "/" + fechaIni.DateTime.Date.Day.ToString();
            string fPerFin = fechaFin.DateTime.Date.Year.ToString() + "/" + fechaFin.DateTime.Date.Month.ToString() + "/" + fechaFin.DateTime.Date.Day.ToString();
            try
            {
                int periodo;
                try
                {
                    periodo = int.Parse(conexion.fnEjecutarEscalar("SELECT MAX(per_numero)+1 from conta_bd.periodo").ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Es el primer período que se ingresa en la base de datos");
                    periodo = 1;
                }

                string guardar = "INSERT INTO empresa(em_nombre, em_nit,em_direccion, em_telefono, em_fecha_ingreso, us_codigo, em_periodo_actual) " +
                    "VALUES('" + txtEmpresa.Text + "','" + txtNit.Text + "','" + txtDireccion.Text + "'," + txtTel.Text +
                    ",'" + fechaI + "', " + frmPrincipal.usuario + ", " + periodo + ")";
                conexion.fnEjecutarComando(guardar);

                guardar = "INSERT INTO periodo (per_numero, per_fechainicio, per_fechafin, em_codigo) " +
                           "VALUES ("+periodo+",'"+fPerIni+"','"+fPerFin+"',"+int.Parse(txtCodigo.Text)+")";
                conexion.fnEjecutarComando(guardar);

                

                MessageBox.Show("Nuevo cliente guardado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            padre.Enabled = true;
            frmClientes.DefInstance.actualizar();
            this.Close();
        }

        private void frmClientesMantenimiento_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = (conexion.fnEjecutarEscalar("SELECT MAX(em_codigo)+1 from conta_bd.empresa").ToString());
        }      
        
    }
}
