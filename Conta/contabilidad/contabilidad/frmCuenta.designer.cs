namespace verduras
{
    partial class frmCuenta
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
            this.guardarCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.salir = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.comboCtaPadre = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkListEstadosFin = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label10 = new System.Windows.Forms.Label();
            this.monDolares = new System.Windows.Forms.RadioButton();
            this.monQuetzales = new System.Windows.Forms.RadioButton();
            this.chkContabilizable = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcreedora = new DevExpress.XtraEditors.CheckEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCtaNombre = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNivel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodGenerado = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.nuevaCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCtaPadre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListEstadosFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContabilizable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcreedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodGenerado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarCuenta
            // 
            this.guardarCuenta.Location = new System.Drawing.Point(589, 228);
            this.guardarCuenta.Name = "guardarCuenta";
            this.guardarCuenta.Size = new System.Drawing.Size(151, 66);
            this.guardarCuenta.TabIndex = 27;
            this.guardarCuenta.Text = "GUARDAR";
            this.guardarCuenta.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(589, 316);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(151, 62);
            this.salir.TabIndex = 28;
            this.salir.Text = "SALIR";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblNombreCuenta);
            this.panelControl2.Controls.Add(this.comboCtaPadre);
            this.panelControl2.Controls.Add(this.chkListEstadosFin);
            this.panelControl2.Controls.Add(this.label10);
            this.panelControl2.Controls.Add(this.monDolares);
            this.panelControl2.Controls.Add(this.monQuetzales);
            this.panelControl2.Controls.Add(this.chkContabilizable);
            this.panelControl2.Controls.Add(this.chkAcreedora);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.txtCtaNombre);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.comboNivel);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.txtCodGenerado);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(569, 434);
            this.panelControl2.TabIndex = 0;
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Enabled = false;
            this.lblNombreCuenta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombreCuenta.Location = new System.Drawing.Point(132, 106);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(103, 17);
            this.lblNombreCuenta.TabIndex = 47;
            this.lblNombreCuenta.Text = "Nombre cuenta";
            // 
            // comboCtaPadre
            // 
            this.comboCtaPadre.Location = new System.Drawing.Point(230, 60);
            this.comboCtaPadre.Name = "comboCtaPadre";
            this.comboCtaPadre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCtaPadre.Properties.Appearance.Options.UseFont = true;
            this.comboCtaPadre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboCtaPadre.Size = new System.Drawing.Size(102, 30);
            this.comboCtaPadre.TabIndex = 46;
            this.comboCtaPadre.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.comboCtaPadre_Closed_1);
            // 
            // chkListEstadosFin
            // 
            this.chkListEstadosFin.CheckOnClick = true;
            this.chkListEstadosFin.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Estado de Resultados"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Balance General"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Flujo de Caja"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Costo Producción")});
            this.chkListEstadosFin.Location = new System.Drawing.Point(230, 339);
            this.chkListEstadosFin.Name = "chkListEstadosFin";
            this.chkListEstadosFin.Size = new System.Drawing.Size(247, 83);
            this.chkListEstadosFin.TabIndex = 45;
            this.chkListEstadosFin.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkListEstadosFin_ItemCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label10.Location = new System.Drawing.Point(17, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Estado(s) Financiero(s):";
            // 
            // monDolares
            // 
            this.monDolares.AutoSize = true;
            this.monDolares.Font = new System.Drawing.Font("Tahoma", 10F);
            this.monDolares.Location = new System.Drawing.Point(360, 266);
            this.monDolares.Name = "monDolares";
            this.monDolares.Size = new System.Drawing.Size(93, 21);
            this.monDolares.TabIndex = 43;
            this.monDolares.Text = "($) Dólares";
            this.monDolares.UseVisualStyleBackColor = true;
            // 
            // monQuetzales
            // 
            this.monQuetzales.AutoSize = true;
            this.monQuetzales.Checked = true;
            this.monQuetzales.Font = new System.Drawing.Font("Tahoma", 10F);
            this.monQuetzales.Location = new System.Drawing.Point(230, 266);
            this.monQuetzales.Name = "monQuetzales";
            this.monQuetzales.Size = new System.Drawing.Size(108, 21);
            this.monQuetzales.TabIndex = 42;
            this.monQuetzales.TabStop = true;
            this.monQuetzales.Text = "(Q) Quetzales";
            this.monQuetzales.UseVisualStyleBackColor = true;
            // 
            // chkContabilizable
            // 
            this.chkContabilizable.EditValue = true;
            this.chkContabilizable.Location = new System.Drawing.Point(228, 230);
            this.chkContabilizable.Name = "chkContabilizable";
            this.chkContabilizable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkContabilizable.Properties.Appearance.Options.UseFont = true;
            this.chkContabilizable.Properties.Caption = "Sí";
            this.chkContabilizable.Size = new System.Drawing.Size(59, 23);
            this.chkContabilizable.TabIndex = 41;
            // 
            // chkAcreedora
            // 
            this.chkAcreedora.Location = new System.Drawing.Point(228, 299);
            this.chkAcreedora.Name = "chkAcreedora";
            this.chkAcreedora.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkAcreedora.Properties.Appearance.Options.UseFont = true;
            this.chkAcreedora.Properties.Caption = "Acreedora";
            this.chkAcreedora.Size = new System.Drawing.Size(116, 23);
            this.chkAcreedora.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(15, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Naturaleza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(15, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Contabilizable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Moneda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nombre:";
            // 
            // txtCtaNombre
            // 
            this.txtCtaNombre.Location = new System.Drawing.Point(230, 182);
            this.txtCtaNombre.Name = "txtCtaNombre";
            this.txtCtaNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCtaNombre.Properties.Appearance.Options.UseFont = true;
            this.txtCtaNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCtaNombre.Size = new System.Drawing.Size(266, 32);
            this.txtCtaNombre.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Código generado:";
            // 
            // comboNivel
            // 
            this.comboNivel.EditValue = "Categoría";
            this.comboNivel.Location = new System.Drawing.Point(230, 12);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboNivel.Properties.Appearance.Options.UseFont = true;
            this.comboNivel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboNivel.Properties.Items.AddRange(new object[] {
            "Categoría",
            "Sub-Categoría",
            "Mayor",
            "Cuenta",
            "Sub-Cuenta"});
            this.comboNivel.Size = new System.Drawing.Size(266, 30);
            this.comboNivel.TabIndex = 22;
            this.comboNivel.SelectedIndexChanged += new System.EventHandler(this.comboNivel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nivel:";
            // 
            // txtCodGenerado
            // 
            this.txtCodGenerado.EditValue = "0";
            this.txtCodGenerado.Enabled = false;
            this.txtCodGenerado.Location = new System.Drawing.Point(230, 140);
            this.txtCodGenerado.Name = "txtCodGenerado";
            this.txtCodGenerado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCodGenerado.Properties.Appearance.Options.UseFont = true;
            this.txtCodGenerado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCodGenerado.Size = new System.Drawing.Size(266, 32);
            this.txtCodGenerado.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(15, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Código cuenta padre:";
            // 
            // nuevaCuenta
            // 
            this.nuevaCuenta.Location = new System.Drawing.Point(589, 142);
            this.nuevaCuenta.Name = "nuevaCuenta";
            this.nuevaCuenta.Size = new System.Drawing.Size(151, 66);
            this.nuevaCuenta.TabIndex = 29;
            this.nuevaCuenta.Text = "NUEVO";
            this.nuevaCuenta.Click += new System.EventHandler(this.nuevaCuenta_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(589, 57);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 66);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "VER CATALOGO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.nuevaCuenta);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.guardarCuenta);
            this.Name = "frmCuenta";
            this.Text = "-..-   Mantenimiento de Cuentas   -..-";
            this.Enter += new System.EventHandler(this.comboNivel_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCtaPadre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListEstadosFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContabilizable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcreedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodGenerado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton guardarCuenta;
        private DevExpress.XtraEditors.SimpleButton salir;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboNivel;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtCodGenerado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCtaNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton monDolares;
        private System.Windows.Forms.RadioButton monQuetzales;
        private DevExpress.XtraEditors.CheckEdit chkContabilizable;
        private DevExpress.XtraEditors.CheckEdit chkAcreedora;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListEstadosFin;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton nuevaCuenta;
        private DevExpress.XtraEditors.ComboBoxEdit comboCtaPadre;
        private System.Windows.Forms.Label lblNombreCuenta;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}