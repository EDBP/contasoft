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
    public partial class frmClientes : Form
    {
        DataTable dtusuarios;
        private static frmClientes m_FormDefInstance;
        public static frmClientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmClientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }       
 
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizar(); 
        }

        public void actualizar()
        {
            dtusuarios = new DataTable();            
            dtusuarios = conexion.fnEjecutarConsulta("select e.em_codigo, e.em_nombre, e.em_nit, e.em_direccion, e.em_telefono, "
                        +"e.em_fecha_ingreso, u.us_nombre_completo from empresa e "
                        +"inner join usuario u on u.us_codigo = e.us_codigo"); 
            dtClientes.DataSource = dtusuarios;
            
            dtClientes.Columns[0].Visible = false;
            
            dtClientes.Columns[1].HeaderText = "Nombre del cliente";
            dtClientes.Columns[1].Width = 300;

            dtClientes.Columns[2].HeaderText = "Nit";
            dtClientes.Columns[2].Width = 100;

            dtClientes.Columns[3].HeaderText = "Dirección";
            dtClientes.Columns[3].Width = 250;

            dtClientes.Columns[4].HeaderText = "Teléfono";
            dtClientes.Columns[4].Width = 120;
                                   
            dtClientes.Columns[5].HeaderText = "Fecha de ingreso";
            dtClientes.Columns[5].Width = 120;

            dtClientes.Columns[6].HeaderText = "Responsable";
            dtClientes.Columns[6].Width = 150;
                        
            for (int i = 0; i <= 6; i++)
            {
                dtClientes.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11F, FontStyle.Regular);
                dtClientes.Columns[i].ReadOnly = true;
                dtClientes.Columns[i].Resizable = DataGridViewTriState.False;
            }
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmClientesMantenimiento fClientesMant = new frmClientesMantenimiento(this);
            fClientesMant.btnGuardar.Text = "Guardar nuevo";            
            fClientesMant.Show();
            this.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClientesMantenimiento fClientesMant = new frmClientesMantenimiento(this);
            fClientesMant.txtCodigo.Text = dtusuarios.AsDataView()[e.RowIndex][0].ToString();
            fClientesMant.txtNit.Text = dtusuarios.AsDataView()[e.RowIndex][2].ToString();
            fClientesMant.txtEmpresa.Text = dtusuarios.AsDataView()[e.RowIndex][1].ToString();
            fClientesMant.txtDireccion.Text = dtusuarios.AsDataView()[e.RowIndex][3].ToString();
            fClientesMant.txtTel.Text = dtusuarios.AsDataView()[e.RowIndex][4].ToString();
            fClientesMant.lblResponsable.Text = dtusuarios.AsDataView()[e.RowIndex][6].ToString();
            fClientesMant.fechaIngreso.DateTime = Convert.ToDateTime(dtusuarios.AsDataView()[e.RowIndex][5]);
            fClientesMant.btnGuardar.Text = "Guardar Cambios";
            fClientesMant.Show();
            this.Enabled = false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
