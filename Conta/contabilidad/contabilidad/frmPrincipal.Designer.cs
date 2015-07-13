namespace contabilidad
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNomenclatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompras = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btnBalance = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiario = new DevExpress.XtraBars.BarButtonItem();
            this.btnMayor = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnER = new DevExpress.XtraBars.BarButtonItem();
            this.btnBG = new DevExpress.XtraBars.BarButtonItem();
            this.btnFlujoCaja = new DevExpress.XtraBars.BarButtonItem();
            this.btnCostoProd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelecEmpresa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BarraDeEstado = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.rPGReportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barStaticUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonUsuario = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonEmpresa = new DevExpress.XtraBars.BarButtonGroup();
            this.BarStaticEmpresa = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStatItmEmpresa = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barStatItmUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNomenclatura,
            this.btnCompras,
            this.btnVentas,
            this.btnInventario,
            this.btnBalance,
            this.btnDiario,
            this.btnMayor,
            this.btnClientes,
            this.btnER,
            this.btnBG,
            this.btnFlujoCaja,
            this.btnCostoProd,
            this.btnUsuarios,
            this.btnSelecEmpresa,
            this.barStaticUsuario,
            this.barButtonUsuario,
            this.barButtonEmpresa,
            this.BarStaticEmpresa,
            this.barStatItmEmpresa,
            this.barButtonGroup1,
            this.barStatItmUsuario,
            this.barStaticItem1,
            this.barStaticItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage6,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.Size = new System.Drawing.Size(787, 144);
            // 
            // btnNomenclatura
            // 
            this.btnNomenclatura.Caption = "Nomenclatura de cuentas";
            this.btnNomenclatura.Id = 1;
            this.btnNomenclatura.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNomenclatura.LargeGlyph")));
            this.btnNomenclatura.Name = "btnNomenclatura";
            this.btnNomenclatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNomenclatura_ItemClick);
            // 
            // btnCompras
            // 
            this.btnCompras.Caption = "Compras";
            this.btnCompras.Id = 2;
            this.btnCompras.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCompras.LargeGlyph")));
            this.btnCompras.Name = "btnCompras";
            // 
            // btnVentas
            // 
            this.btnVentas.Caption = "Ventas";
            this.btnVentas.Id = 3;
            this.btnVentas.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVentas.LargeGlyph")));
            this.btnVentas.Name = "btnVentas";
            // 
            // btnInventario
            // 
            this.btnInventario.Caption = "Inventario";
            this.btnInventario.Id = 4;
            this.btnInventario.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnInventario.LargeGlyph")));
            this.btnInventario.Name = "btnInventario";
            // 
            // btnBalance
            // 
            this.btnBalance.Caption = "Balance";
            this.btnBalance.Id = 5;
            this.btnBalance.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBalance.LargeGlyph")));
            this.btnBalance.Name = "btnBalance";
            // 
            // btnDiario
            // 
            this.btnDiario.Caption = "Diario";
            this.btnDiario.Id = 6;
            this.btnDiario.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDiario.LargeGlyph")));
            this.btnDiario.Name = "btnDiario";
            this.btnDiario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiario_ItemClick);
            // 
            // btnMayor
            // 
            this.btnMayor.Caption = "Mayor";
            this.btnMayor.Id = 8;
            this.btnMayor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMayor.LargeGlyph")));
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMayor_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Gestión de empresas";
            this.btnClientes.Id = 9;
            this.btnClientes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClientes.LargeGlyph")));
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnER
            // 
            this.btnER.Caption = "Estado de resultados";
            this.btnER.Id = 10;
            this.btnER.Name = "btnER";
            // 
            // btnBG
            // 
            this.btnBG.Caption = "Balance general";
            this.btnBG.Id = 11;
            this.btnBG.Name = "btnBG";
            // 
            // btnFlujoCaja
            // 
            this.btnFlujoCaja.Caption = "Flujo de caja";
            this.btnFlujoCaja.Id = 12;
            this.btnFlujoCaja.Name = "btnFlujoCaja";
            // 
            // btnCostoProd
            // 
            this.btnCostoProd.Caption = "Costo producción";
            this.btnCostoProd.Id = 13;
            this.btnCostoProd.Name = "btnCostoProd";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Caption = "Gestión de usuarios";
            this.btnUsuarios.Id = 14;
            this.btnUsuarios.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.LargeGlyph")));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // btnSelecEmpresa
            // 
            this.btnSelecEmpresa.Caption = "Seleccionar Empresa";
            this.btnSelecEmpresa.Id = 15;
            this.btnSelecEmpresa.Name = "btnSelecEmpresa";
            this.btnSelecEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelecEmpresa_ItemClick);
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Acciones";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnSelecEmpresa);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Catálogo";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNomenclatura);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Libros contables";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCompras);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVentas);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInventario);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBalance);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDiario);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMayor);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Clientes";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClientes);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Estados financieros";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnER);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBG);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnFlujoCaja);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCostoProd);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Mantenimiento";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUsuarios);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // BarraDeEstado
            // 
            this.BarraDeEstado.ItemLinks.Add(this.barStaticItem1);
            this.BarraDeEstado.ItemLinks.Add(this.barStatItmEmpresa);
            this.BarraDeEstado.ItemLinks.Add(this.barStaticItem2);
            this.BarraDeEstado.ItemLinks.Add(this.barStatItmUsuario);
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 509);
            this.BarraDeEstado.Name = "BarraDeEstado";
            this.BarraDeEstado.Ribbon = this.ribbon;
            this.BarraDeEstado.Size = new System.Drawing.Size(787, 31);
            // 
            // rPGReportes
            // 
            this.rPGReportes.Name = "rPGReportes";
            this.rPGReportes.ShowCaptionButton = false;
            // 
            // barStaticUsuario
            // 
            this.barStaticUsuario.Caption = "Usuario";
            this.barStaticUsuario.Id = 16;
            this.barStaticUsuario.Name = "barStaticUsuario";
            this.barStaticUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonUsuario
            // 
            this.barButtonUsuario.Caption = "Usuario";
            this.barButtonUsuario.Id = 18;
            this.barButtonUsuario.ItemLinks.Add(this.barStaticUsuario);
            this.barButtonUsuario.Name = "barButtonUsuario";
            // 
            // barButtonEmpresa
            // 
            this.barButtonEmpresa.Caption = "Empresa";
            this.barButtonEmpresa.Id = 19;
            this.barButtonEmpresa.ItemLinks.Add(this.BarStaticEmpresa);
            this.barButtonEmpresa.Name = "barButtonEmpresa";
            // 
            // BarStaticEmpresa
            // 
            this.BarStaticEmpresa.Caption = "Empresa";
            this.BarStaticEmpresa.Id = 20;
            this.BarStaticEmpresa.Name = "BarStaticEmpresa";
            this.BarStaticEmpresa.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStatItmEmpresa
            // 
            this.barStatItmEmpresa.Caption = "-";
            this.barStatItmEmpresa.Id = 22;
            this.barStatItmEmpresa.Name = "barStatItmEmpresa";
            this.barStatItmEmpresa.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStatItmEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem1_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 23;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barStatItmUsuario
            // 
            this.barStatItmUsuario.Caption = "-";
            this.barStatItmUsuario.Id = 24;
            this.barStatItmUsuario.Name = "barStatItmUsuario";
            this.barStatItmUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Empresa: ";
            this.barStaticItem1.Id = 25;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Usuario: ";
            this.barStaticItem2.Id = 26;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 540);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.BarraDeEstado;
            this.Text = "-\'- Principal -\'-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnNomenclatura;
        private DevExpress.XtraBars.BarButtonItem btnCompras;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnVentas;
        private DevExpress.XtraBars.BarButtonItem btnInventario;
        private DevExpress.XtraBars.BarButtonItem btnBalance;
        private DevExpress.XtraBars.BarButtonItem btnDiario;
        private DevExpress.XtraBars.BarButtonItem btnMayor;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnER;
        private DevExpress.XtraBars.BarButtonItem btnBG;
        private DevExpress.XtraBars.BarButtonItem btnFlujoCaja;
        private DevExpress.XtraBars.BarButtonItem btnCostoProd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGReportes;
        private DevExpress.XtraBars.BarButtonItem btnSelecEmpresa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarStaticItem barStaticUsuario;
        private DevExpress.XtraBars.BarStaticItem BarStaticEmpresa;
        public DevExpress.XtraBars.BarButtonGroup barButtonUsuario;
        public DevExpress.XtraBars.Ribbon.RibbonStatusBar BarraDeEstado;
        private DevExpress.XtraBars.BarButtonGroup barButtonEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraBars.BarStaticItem barStatItmEmpresa;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        public DevExpress.XtraBars.BarStaticItem barStatItmUsuario;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
    }
}