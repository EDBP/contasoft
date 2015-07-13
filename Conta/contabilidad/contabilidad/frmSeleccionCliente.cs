using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace contabilidad
{
    public partial class frmSeleccionCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmSeleccionCliente()
        {
            InitializeComponent();
        }
        private static frmSeleccionCliente m_FormDefInstance;
        public static frmSeleccionCliente DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmSeleccionCliente();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private DataTable dataEmpresa = new DataTable();
        private void frmSeleccionCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void listEmpresas_DoubleClick(object sender, EventArgs e)
        {
            seleccionar_empresa();
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            frmClientesMantenimiento fClientesMant = new frmClientesMantenimiento(this);
            fClientesMant.btnGuardar.Text = "Guardar nuevo";
            fClientesMant.ShowDialog();
            //Refrescar la lista de empresas
            actualizar_lista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar_empresa();
        }

        private void seleccionar_empresa()
        {
            MessageBox.Show("Empresa "+listEmpresas.Text+" Seleccionada");
            frmPrincipal f1 = (frmPrincipal)this.MdiParent;
            f1.Text = "Trabajando Empresa " + listEmpresas.Text;
            f1.barStatItmEmpresa.Caption = listEmpresas.Text;


            this.Close();
            //MessageBox.Show(listEmpresas.SelectedValue.ToString());   
        }

        private void frmSeleccionCliente_Activated(object sender, EventArgs e)
        {
            
        }

        private void frmSeleccionCliente_Enter(object sender, EventArgs e)
        {
            actualizar_lista();
        }

        private void frmSeleccionCliente_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
        private void actualizar_lista()
        {
            dataEmpresa = conexion.fnEjecutarConsulta("SELECT em_codigo, em_nombre FROM conta_bd.empresa");
            listEmpresas.DataSource = dataEmpresa;
            listEmpresas.DisplayMember = "em_nombre";
            listEmpresas.ValueMember = "em_codigo";
        }
    }
}