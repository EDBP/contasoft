using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using verduras;

namespace contabilidad
{
    public partial class frmVistaCatalogo : DevExpress.XtraEditors.XtraForm
    {
        public frmVistaCatalogo()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            
        }
        bool estado;
        private void frmVistaCatalogo_Load(object sender, EventArgs e)
        {
            estado = false;
            DataTable dt = null;

            string sSql = "SELECT cu_padre, cu_codigo, cu_nombre, cu_codigo as codigo FROM cuenta";
            try
            {
                dt = conexion.fnEjecutarConsulta(sSql);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("vacio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Text, ex.Message.ToString());
            }
            trl.Nodes.Clear();
            trl.DataSource = dt;
            trl.ParentFieldName = "cu_padre";
            trl.KeyFieldName = "cu_codigo";

            trl.Columns["cu_nombre"].Caption = "Nombre Cuenta";
            trl.Columns["codigo"].Caption = "Codigo";

            this.trl.ExpandAll();
        }
        
    }
}