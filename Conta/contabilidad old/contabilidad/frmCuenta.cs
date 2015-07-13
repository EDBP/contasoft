using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Globalization;
using contabilidad;

namespace verduras
{
    public partial class frmCuenta : DevExpress.XtraEditors.XtraForm
    {
        int cod_usuario;
        public frmCuenta()
        {
            InitializeComponent();
        }
        public void identificarusuario(int quien)
        {
            cod_usuario = quien;
        }

        private static frmCuenta m_FormDefInstance;
        public static frmCuenta DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmCuenta();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
          
        private void limpiar()
        {
            txtCtaNombre.Text = "";
            chkContabilizable.Checked = true;
            monQuetzales.Checked = true;
            chkAcreedora.Checked = false;
            fechaIni.DateTime = DateTime.Now.Date;
            fechaFin.DateTime = DateTime.Now.Date;
            cod_cat = "0";
            comboCtaPadre.Select();
        }

        private void nueva_cuenta()
        {
            txtCtaNombre.Text = "";
            chkContabilizable.Checked = true;
            monQuetzales.Checked = true;
            chkAcreedora.Checked = false;
            guardarCuenta.Enabled = true;
            cod_cat = "0";
            comboCtaPadre.Select();
        }
        
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            int moneda = 0;
            int nivel = 0;
            int contabilizable = 0;
            int acreedora = 0;
            if (monDolares.Checked) 
                moneda = 1;
            if (chkContabilizable.Checked)
                contabilizable = 1;
            if (chkAcreedora.Checked)
                acreedora = 1;
            switch (comboNivel.SelectedItem.ToString())
            {
                case "Categoría":
                    nivel = 1;
                    break;
                case "Sub-Categoría":
                    nivel = 2;
                    break;
                case "Mayor":
                    nivel = 3;
                    break;
                case "Cuenta":
                    nivel = 4;
                    break;
                case "Sub-Cuenta":
                    nivel = 5;
                    break;
            }
            
            try
            { 
            string fechaI = fechaIni.DateTime.Date.Year.ToString()+"/"+fechaIni.DateTime.Date.Month.ToString()+"/"+fechaIni.DateTime.Date.Day.ToString();
            string fechaF = fechaFin.DateTime.Date.Year.ToString()+"/"+fechaFin.DateTime.Date.Month.ToString()+"/"+fechaFin.DateTime.Date.Day.ToString();
            string guardar = "INSERT INTO cuenta(cu_codigo, cu_nombre, cu_padre, cu_fecha_inicio, cu_fecha_fin, cu_moneda, "
                                + "cu_nivel, cu_digitos, cu_contabilizable, cu_naturaleza, ca_codigo, us_codigo) " +
                                "VALUES(" +"'"+ txtCodGenerado.Text +
                                    "','" + txtCtaNombre.Text +
                                    "','" + comboCtaPadre.Text + 
                                    "','" + fechaI + 
                                    "','" + fechaF +
                                    "','" + moneda +
                                    "','" + nivel +
                                    "','" + txtCodGenerado.Text.Length +
                                    "','" + contabilizable +
                                    "','" + acreedora +
                                    "','" + cod_cat +
                                    "','" + cod_usuario + "')";    
                
                //Una cuenta puede pertenecer a 1 o más estados financieros, por lo tanto la relación (en el diagrama 
                //de la bd ...creo que es a la inversa.
                //FALTA: Ingresar en la tabla CATEGORÍA la cuenta y sus relaciones (con los estados financieros).
                conexion.fnEjecutarComando(guardar);                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
            nueva_cuenta();
        }

        private void nuevaCuenta_Click(object sender, EventArgs e)
        {
            nueva_cuenta();
        }


        private void comprobar()
        {
            switch (comboNivel.SelectedItem.ToString())
            {
                case "Categoría":
                    chkAcreedora.Enabled = false;
                    comboCtaPadre.Properties.Items.Clear();
                    comboCtaPadre.Text = "0";
                    DataTable consulta_n1 = conexion.fnEjecutarConsulta("SELECT max(cu_codigo) FROM cuenta WHERE cu_nivel= '" + "1" + "'");

                    if ((consulta_n1.Rows.Count <= 1) && (consulta_n1.Rows[0][0].ToString() == ""))
                    {
                        txtCodGenerado.Text = "1";
                        lblNombreCuenta.Text = "Raiz";
                    }
                    else
                    {
                        txtCodGenerado.Text = (int.Parse(consulta_n1.Rows[0][0].ToString()) + 1).ToString();
                        lblNombreCuenta.Text = "Raiz";
                    }
                    break;

                case "Sub-Categoría":
                    chkAcreedora.Enabled = false;
                    comboCtaPadre.Properties.Items.Clear();
                    Generar_Codigo_Nivel(comboCtaPadre.Text, 2);
                    break;

                case "Mayor":
                    chkAcreedora.Enabled = true;
                    comboCtaPadre.Properties.Items.Clear();
                    Generar_Codigo_Nivel(comboCtaPadre.Text, 3);
                    break;

                case "Cuenta":
                    chkAcreedora.Enabled = true;
                    comboCtaPadre.Properties.Items.Clear();
                    Generar_Codigo_Nivel(comboCtaPadre.Text, 4);
                    break;
                case "Sub-Cuenta":
                    chkAcreedora.Enabled = true;
                    comboCtaPadre.Properties.Items.Clear();
                    Generar_Codigo_Nivel(comboCtaPadre.Text, 5);
                    break;
            }
        }

        private void Generar_Codigo_Nivel(string padre, int nivel)
        {
            DataTable consulta = conexion.fnEjecutarConsulta("SELECT * FROM cuenta WHERE cu_nivel= '" + (nivel-1).ToString() + "'");
            for (int i = 0; i < consulta.Rows.Count; i++)
            {
                comboCtaPadre.Properties.Items.Add(consulta.Rows[i]["cu_codigo"]);
            }
            comboCtaPadre.SelectedIndex = 0;

            maximo_siguiente();
        }

        private void comboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobar();
        }
        
        private void comboNivel_Enter(object sender, EventArgs e)
        {
            comprobar();
        }

        string cod_cat;
        private void chkListEstadosFin_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {

            switch (chkListEstadosFin.SelectedItem.ToString())
            {
                case "Estado de Resultados":
                    chkListEstadosFin.Items[1].CheckState = 0;
                    chkListEstadosFin.Items[2].CheckState = 0;
                    chkListEstadosFin.Items[3].CheckState = 0;
                    if (txtCodGenerado.Text.Length == 5)
                    {
                        ubicar_estado_financiero(txtCodGenerado.Text.Substring(0, 3));
                    }

                break;
                case "Balance General":
                    chkListEstadosFin.Items[0].CheckState = 0;
                    chkListEstadosFin.Items[2].CheckState = 0;
                    chkListEstadosFin.Items[3].CheckState = 0;
                    if (txtCodGenerado.Text.Length == 5)
                    {
                        ubicar_estado_financiero(txtCodGenerado.Text.Substring(0, 3));
                    }

                break;
                case "Flujo de Caja":
                    chkListEstadosFin.Items[0].CheckState = 0;
                    chkListEstadosFin.Items[1].CheckState = 0;
                    chkListEstadosFin.Items[3].CheckState = 0;
                    if (txtCodGenerado.Text.Length == 5)
                    {
                        ubicar_estado_financiero(txtCodGenerado.Text.Substring(0, 3));
                    }
                break;
                case "Costo Producción":
                    chkListEstadosFin.Items[0].CheckState = 0;
                    chkListEstadosFin.Items[1].CheckState = 0;
                    chkListEstadosFin.Items[2].CheckState = 0;
                    if (txtCodGenerado.Text.Length == 5)
                    {
                       ubicar_estado_financiero(txtCodGenerado.Text.Substring(0, 3));
                    }
                break;
            }
            if (chkListEstadosFin.SelectedItem != null)
            {
                guardarCuenta.Enabled = true;
            }
        }

        private void ubicar_estado_financiero(string codigo)
        {
            switch (codigo)
            {
                    case "101":
                        cod_cat = "1A";
                    break;
                    case "102":
                        cod_cat = "2A";
                    break;
                    case "103":
                        cod_cat = "3A";
                    break;
                    case "201":
                        cod_cat = "1P";
                    break;
                    case "202":
                        cod_cat = "2P";
                    break;
                    case "203":
                        cod_cat = "3P";
                    break;
                    case "301":
                        cod_cat = "C";
                    break;
                    case "401":
                        cod_cat = "1R";
                    break;
                    case "402":
                        cod_cat = "2R";
                    break;
                    case "403":
                        cod_cat = "3R";
                    break;
                    case "404":
                        cod_cat = "4R";
                    break;
                    default:
                        cod_cat = "0";
                    break;
            }

        }


        private void comboCtaPadre_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            maximo_siguiente();
        }
         
        private void maximo_siguiente()
        {
            if (comboCtaPadre.Text != "0")
            {
                //que busque el maximo que sigue segun el padre
                DataTable consulta_max_en_nivel = conexion.fnEjecutarConsulta("SELECT max(cu_codigo) FROM cuenta WHERE cu_codigo like '" + comboCtaPadre.Text + "__'");
                if (consulta_max_en_nivel.Rows[0][0].ToString() != "")
                {
                    txtCodGenerado.Text = ((int.Parse(consulta_max_en_nivel.Rows[0][0].ToString()) + 1).ToString());
                    identificar_cuenta(comboCtaPadre.Text);
                }
                else
                {
                    txtCodGenerado.Text = (comboCtaPadre.Text + "01");
                    identificar_cuenta(comboCtaPadre.Text);
                }

            }
        }
        private void identificar_cuenta(string no_cuenta)
        {
            lblNombreCuenta.Text = nombre_cuenta(no_cuenta);
                //consultar_no_cuenta.Rows[0][0].ToString();
        }

        public static string nombre_cuenta(string id_cuenta)
        {
            if (conexion.fnEjecutarEscalar("SELECT cu_padre FROM cuenta where cu_codigo =" + id_cuenta).ToString() == "0")
                return "Raiz ->" + conexion.fnEjecutarEscalar("SELECT cu_nombre FROM cuenta where cu_codigo =" + id_cuenta).ToString();
            return nombre_cuenta(conexion.fnEjecutarEscalar("SELECT cu_padre FROM conta_bd.cuenta where cu_codigo =" + id_cuenta).ToString()) + " ->" + (conexion.fnEjecutarEscalar("SELECT cu_nombre FROM cuenta where cu_codigo =" + id_cuenta).ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmVistaCatalogo Catalogo = new frmVistaCatalogo();
            Catalogo.ShowDialog();
        }

       

        private void comboCtaPadre_TextChanged(object sender, EventArgs e)
        {
            maximo_siguiente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificar("10101");
        }

        private void modificar(string id_cuenta)
        {
            DataTable consulta_edicion = conexion.fnEjecutarConsulta("SELECT * FROM cuenta WHERE cu_codigo = '" + id_cuenta + "'");
            identificar_nivel(int.Parse(consulta_edicion.Rows[0][6].ToString()));
            comboCtaPadre.Text = consulta_edicion.Rows[0][2].ToString();
            txtCodGenerado.Text= consulta_edicion.Rows[0][0].ToString();
            txtCtaNombre.Text = consulta_edicion.Rows[0][1].ToString();
            if (consulta_edicion.Rows[0][8].ToString() == "True")
                chkContabilizable.Checked = true;
            else
                chkContabilizable.Checked = false;
            if (consulta_edicion.Rows[0][5].ToString() == "0")
            {
                monQuetzales.Checked = true;
                monDolares.Checked = false;
            }
            else
            {
                monQuetzales.Checked = false;
                monDolares.Checked = true;
            }
            if (consulta_edicion.Rows[0][9].ToString() == "1")
                chkAcreedora.Checked = true;
            else
                chkAcreedora.Checked = false;
            fechaIni.Text = String.Format("{0:dd/MM/yyyy}",consulta_edicion.Rows[0][3]).ToString();
            fechaFin.Text = String.Format("{0:dd/MM/yyyy}",consulta_edicion.Rows[0][4]).ToString();
        }
        private void identificar_nivel(int nivel)
        {
            switch (nivel)
            {
                case 1:
                    comboNivel.Text = "Categoría";
                    break;
                case 2:
                    comboNivel.Text = "Sub-Categoría";
                    break;
                case 3:
                    comboNivel.Text = "Mayor";
                    break;
                case 4:
                    comboNivel.Text = "Cuenta";
                    break;
                case 5:
                    comboNivel.Text = "Sub-Cuenta";
                    break;
            }
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            limpiar();
        }
        
    }
}