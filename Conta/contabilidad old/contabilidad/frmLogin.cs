using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace verduras
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable datos = conexion.fnEjecutarConsulta("SELECT us_codigo, us_usuario, us_contrasena FROM usuario WHERE us_usuario= '" + txtUsuario.Text + "'");
            if (datos.Rows.Count > 0)
            {
                if (datos.Rows[0][2].ToString().Equals(txtContraseña.Text))
                {
                    frmPrincipal principal = new frmPrincipal(this);
                    principal.identificarusuario(int.Parse(datos.Rows[0][0].ToString()));
                    principal.Show();
                    this.Hide(); //Por el momento solamente se esconderá ésta ventana.
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe");
                txtUsuario.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}