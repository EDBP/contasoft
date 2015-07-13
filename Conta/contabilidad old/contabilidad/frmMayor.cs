using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace verduras
{
    public partial class frmMayor : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtbuscarproducto;

        private static frmMayor m_FormDefInstance;
        public static frmMayor DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmMayor();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public frmMayor()
        {
            InitializeComponent();
        }
               
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}