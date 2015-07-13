using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using verduras;

namespace contabilidad
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form padre;        
        public static int usuario = 1;

        public frmPrincipal(Form Padre)
        {
            this.padre = Padre;
            InitializeComponent();           
        }

        public void identificarusuario(int quien)
        {
            usuario = quien;
        }
        

        private void btnNomenclatura_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCuenta.DefInstance.MdiParent = this;
            frmCuenta.DefInstance.identificarusuario(usuario);
            frmCuenta.DefInstance.Show();
            frmCuenta.DefInstance.Activate();
            frmCuenta.DefInstance.BringToFront();
        }

        private void btnDiario_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDiario.DefInstance.MdiParent = this;
            frmDiario.DefInstance.Show();
            frmDiario.DefInstance.Activate();
            frmDiario.DefInstance.BringToFront();
        }

        private void btnMayor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMayor.DefInstance.MdiParent = this;
            frmMayor.DefInstance.Show();
            frmMayor.DefInstance.Activate();
            frmMayor.DefInstance.BringToFront();
        }

        private void btnClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmClientes.DefInstance.MdiParent = this;
            frmClientes.DefInstance.Show();
            frmClientes.DefInstance.Activate();
            frmClientes.DefInstance.BringToFront();
        }

        private void btnUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuarios.DefInstance.MdiParent = this;
            frmUsuarios.DefInstance.Show();
            frmUsuarios.DefInstance.Activate();
            frmUsuarios.DefInstance.BringToFront();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Close();
        }

        private void btnSelecEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSeleccionCliente.DefInstance.MdiParent = this;
            frmSeleccionCliente.DefInstance.Show();
            frmSeleccionCliente.DefInstance.Activate();
            frmSeleccionCliente.DefInstance.BringToFront();
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}