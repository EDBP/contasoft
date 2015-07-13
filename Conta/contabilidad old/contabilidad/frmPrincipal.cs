using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MySql.Data.MySqlClient;

namespace verduras
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form padre;
        
        public int usuario = 0;

        public frmPrincipal(Form Padre)
        {
            this.padre = Padre;
            InitializeComponent();           
        }

        public void identificarusuario(int quien)
        {
            usuario = quien;
        }

        private void barBotonClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmClientes.DefInstance.MdiParent = this;
            frmClientes.DefInstance.Show();
            frmClientes.DefInstance.Activate();
            frmClientes.DefInstance.BringToFront();
        }

        private void barBotonInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDiario.DefInstance.MdiParent = this;
            frmDiario.DefInstance.Show();
            frmDiario.DefInstance.Activate();            
            frmDiario.DefInstance.BringToFront();
        }

        private void barBotonVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCuenta.DefInstance.MdiParent = this;
            frmCuenta.DefInstance.identificarusuario(usuario);
            frmCuenta.DefInstance.Show();
            frmCuenta.DefInstance.Activate();
            frmCuenta.DefInstance.BringToFront();
        }

        private void barBotonIngreso_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMayor.DefInstance.MdiParent = this;
            frmMayor.DefInstance.Show();
            frmMayor.DefInstance.Activate();
            frmMayor.DefInstance.BringToFront();
            
        }

        private void barButtonUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuarios.DefInstance.MdiParent = this;
            frmUsuarios.DefInstance.Show();
            frmUsuarios.DefInstance.Activate();
            frmUsuarios.DefInstance.BringToFront();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }
        
        private void barBotonVerInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barBotonIngresos_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        

        private void barBtnMerma_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barBtnVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

    }
}