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
    public partial class frmDiario : DevExpress.XtraEditors.XtraForm
    {
        private static frmDiario m_FormDefInstance;
        private int empresa = 0;
        private int periodo = 0;
        private DataTable datos = new DataTable();
        private DataTable dataEmpresa = new DataTable();
        public frmDiario()
        {            
            InitializeComponent();
            dataEmpresa = conexion.fnEjecutarConsulta("SELECT em_codigo, em_nombre FROM empresa");
            listEmpresas.DataSource = dataEmpresa;
            listEmpresas.DisplayMember = "em_nombre";
            listEmpresas.ValueMember = "em_nombre";
            cargarCuentas();
        }
        
        public static frmDiario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmDiario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btnGuardarAsiento_Click(object sender, EventArgs e)
        {
            string guardar = "INSERT INTO diario(em_codigo, per_numero) " +
                            "VALUES (" + empresa + "," + periodo + ")";
            conexion.fnEjecutarComando(guardar);
            int diario = 0;
            int cuenta = 0;
            int partida = 0;
            double debe, haber;
            try {
                string fAsiento = fechaAsiento.Value.Year.ToString() + "/" + fechaAsiento.Value.Month.ToString() + "/" + fechaAsiento.Value.Day.ToString();
                diario = int.Parse(conexion.fnEjecutarEscalar("SELECT MAX(di_codigo) FROM diario").ToString());
                guardar = "INSERT INTO partida(pa_fecha, di_codigo) VALUES ('" +
                        fAsiento + "'," + diario+")";
                conexion.fnEjecutarComando(guardar);
                
                partida = int.Parse(conexion.fnEjecutarEscalar("SELECT MAX(pa_numero) FROM partida").ToString());                
                for (int i = 0; i<dtDiario.RowCount-1; i++)
                {
                    cuenta = int.Parse(dtDiario[0, i].Value.ToString());
                    try
                    {
                        debe = double.Parse(dtDiario[1, i].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        debe = 0.00;
                    }

                    try
                    {
                        haber = double.Parse(dtDiario[2, i].Value.ToString());
                    }
                    catch (Exception ex2)
                    {
                        haber = 0.00;
                    }
                    guardar = "INSERT INTO detalle_partida(depa_debe, depa_haber, pa_numero, cu_codigo) VALUES (" +
                           debe +"," + haber + "," + partida + "," + cuenta + ")";
                    conexion.fnEjecutarComando(guardar);
                }                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+" No existen registros en el libro Diario");
            }
        }

        private void listEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresa = int.Parse(dataEmpresa.Rows[listEmpresas.SelectedIndex][0].ToString());
            datos = conexion.fnEjecutarConsulta("SELECT * from periodo WHERE em_codigo = "+empresa
                        +" order by per_fechainicio desc");
            periodo = int.Parse(datos.Rows[0][0].ToString());
            string[] fecha = datos.Rows[0][1].ToString().Substring(0,10).Split('/');            
            DateTime ini = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
            fecha = datos.Rows[0][2].ToString().Substring(0, 10).Split('/');
            DateTime fin = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
            fechaAsiento.MaxDate = fin;
            fechaAsiento.MinDate = ini;
        }

        private void cargarCuentas()
        {
            datos = conexion.fnEjecutarConsulta("SELECT cu_codigo, cu_nombre FROM cuenta WHERE cu_contabilizable = 1");
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Descripción";
            cmb.Name = "Cuenta";
            cmb.DisplayMember = "cu_nombre";
            cmb.ValueMember = "cu_codigo";
            cmb.DataSource = datos;
            cmb.AutoComplete = true;
            cmb.ReadOnly = false;
            dtDiario.Columns.Add(cmb);
            dtDiario.Columns.Add("debe", "Debe");
            dtDiario.Columns.Add("haber", "Haber");
            dtDiario.Columns[0].Width = 500;
            dtDiario.Columns[1].Width = 100;
            dtDiario.Columns[2].Width = 100;
        }
       
        private void dtDiario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualuzarPartida();
        }

        private void ActualuzarPartida()
        {
            int contador;
            float debe=0;
            float haber=0;
            

            for (contador = 0; contador < (dtDiario.Rows.Count - 1);
                contador++)
            {


                if (dtDiario.Rows[contador].Cells["debe"].Value != null)
                {
                    // Verifica que las celdas no esten en blanco.
                    if (dtDiario.Rows[contador]
                        .Cells["debe"].Value.ToString().Length != 0)
                    {
                        debe += float.Parse(dtDiario.Rows[contador]
                            .Cells["debe"].Value.ToString());
                    }
                }
                if (dtDiario.Rows[contador].Cells["haber"].Value != null)
                {
                    //  Verifica que las celdas no esten en blanco.
                    if (dtDiario.Rows[contador]
                        .Cells["haber"].Value.ToString().Length != 0)
                    {
                        haber += float.Parse(dtDiario.Rows[contador]
                            .Cells["haber"].Value.ToString());
                    }
                }
            }
            labelControl4.Text = "Q "+debe.ToString();
            labelControl5.Text = "Q "+haber.ToString();
            //si las sumas no son iguales no habilita el boton guardar partida.
            if (labelControl4.Text.Equals(labelControl5.Text))
            {
                btnGuardarAsiento.Enabled = true;
            }
            else
            {
                btnGuardarAsiento.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmDiario_Shown(object sender, EventArgs e)
        {
            frmPrincipal f1 = (frmPrincipal)this.MdiParent;
            DataTable diari = conexion.fnEjecutarConsulta("SELECT di_codigo " +
                                                           "FROM conta_bd.diario " +
                                                            "where em_codigo = (select em_codigo from conta_bd.empresa where em_nombre ='" + f1.barStatItmEmpresa.Caption + "')");
            if (diari.Rows.Count > 0)
            {
                MessageBox.Show(diari.Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("No se  ha creado un  diario para "+f1.barStatItmEmpresa.Caption);
                return;
                this.Close();
            }
        }
    }
}