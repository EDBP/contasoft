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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtUsuarios;
        private string usuario, nombre, contrasena;
        private int id = 1;
        private static frmUsuarios m_FormDefInstance;

        public frmUsuarios()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        public static frmUsuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmUsuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
              
        private void cargarUsuarios()
        {
            dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM Usuario WHERE us_codigo = " + id);
            llenarPermisos();

            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            txtRepContraseña.Enabled = false;
            lblRepetirCont.Enabled = false;
        }

        private void llenarPermisos()
        {
            txtUsuario.Text = dtUsuarios.Rows[0][2].ToString();
            txtNombre.Text = dtUsuarios.Rows[0][1].ToString();
            txtContraseña.Text = dtUsuarios.Rows[0][3].ToString();

            if (int.Parse(dtUsuarios.Rows[0][4].ToString()) == 1)
                chkNomenclatura.Checked = true;
            else
                chkNomenclatura.Checked = false;
            if (int.Parse(dtUsuarios.Rows[0][5].ToString()) == 1)
                chkLibros.Checked = true;
            else
                chkLibros.Checked = false;
            if (int.Parse(dtUsuarios.Rows[0][6].ToString()) == 1)
                chkEstadosFin.Checked = true;
            else
                chkEstadosFin.Checked = false;
            if (int.Parse(dtUsuarios.Rows[0][7].ToString()) == 1)
                chkUsuarios.Checked = true;
            else
                chkUsuarios.Checked = false;
            if (int.Parse(dtUsuarios.Rows[0][8].ToString()) == 1)
                chkEmpresas.Checked = true;
            else
                chkEmpresas.Checked = false;

            txtUsuario.Enabled = false;
            txtNombre.Enabled = false;
            txtContraseña.Enabled = false;
            chkEmpresas.Enabled = false;
            chkNomenclatura.Enabled = false;
            chkEstadosFin.Enabled = false;
            chkLibros.Enabled = false;
            chkUsuarios.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            chkEmpresas.Checked = false;
            chkNomenclatura.Checked = false;
            chkEstadosFin.Checked = true;
            chkLibros.Checked = false;
            chkUsuarios.Checked = false;

            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;

            txtUsuario.Enabled = true;
            txtNombre.Enabled = true;
            txtContraseña.Enabled = true;
            txtRepContraseña.Enabled = true;
            lblRepetirCont.Enabled = true;
            chkEmpresas.Enabled = true;
            chkNomenclatura.Enabled = true;
            chkEstadosFin.Enabled = true;
            chkLibros.Enabled = true;
            chkUsuarios.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;

            txtUsuario.Enabled = true;
            txtNombre.Enabled = true;
            txtContraseña.Enabled = true;
            txtRepContraseña.Enabled = true;
            lblRepetirCont.Enabled = true;
            chkEmpresas.Enabled = true;
            chkNomenclatura.Enabled = true;
            chkEstadosFin.Enabled = true;
            chkLibros.Enabled = true;
            chkUsuarios.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            nombre = txtNombre.Text;
            contrasena = txtContraseña.Text;
            if (!usuario.Equals("") && !nombre.Equals("") && !contrasena.Equals(""))
            {
                if (contrasena.Equals(txtRepContraseña.Text))
                {
                    if (btnModificar.Enabled == false)
                    {
                        conexion.fnEjecutarComando("INSERT INTO Usuario(us_nombre_completo, us_usuario, us_contrasena"
                                    + " us_gnomenclatura, us_glibros, us_estadosfin, us_gusuarios, us_gempresas) "
                                    + "VALUES('" + txtUsuario.Text + "','" + txtNombre.Text + "','" + txtContraseña.Text + "'," + convertir(chkNomenclatura.Checked) + ","
                                    + convertir(chkLibros.Checked) + "," + convertir(chkEstadosFin.Checked) + "," + convertir(chkUsuarios.Checked) + "," + convertir(chkEmpresas.Checked) + ")");
                    }
                    else
                    {
                        conexion.fnEjecutarComando("UPDATE Usuario SET us_nombre_completo='" + txtNombre.Text + "', us_usuario ='" + txtUsuario.Text + "',"
                            + " us_contrasena='" + txtContraseña.Text + "', us_gnomenclatura=" + convertir(chkNomenclatura.Checked) + ", us_glibros="
                            + convertir(chkLibros.Checked) + ", us_estadosfin=" + convertir(chkEstadosFin.Checked) + ", us_gusuarios="
                            + convertir(chkUsuarios.Checked) + ", us_gempresas=" + convertir(chkEmpresas.Checked) + " WHERE us_codigo =" + id);
                    }
                    id = 1;
                    cargarUsuarios();
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, favor de verificar");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
                btnNuevo.Enabled = false;
                btnAtras.Enabled = false;
                btnSiguiente.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = true;
            }
        }

        private int convertir(bool dato)
        {
            if (dato)
                return 1;
            else
                return 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            id--;
            if (id >= 1)
            {
                dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM Usuario WHERE us_codigo = " + id);
                llenarPermisos();
            }
            else
                id++;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            id++;
            dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM Usuario WHERE us_codigo = " + id);
            if (dtUsuarios.Rows.Count > 0)
                llenarPermisos();
            else
                id--;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
    }
}