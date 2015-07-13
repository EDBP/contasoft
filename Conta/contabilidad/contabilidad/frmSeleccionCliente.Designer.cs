namespace contabilidad
{
    partial class frmSeleccionCliente
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
            this.listEmpresas = new System.Windows.Forms.ListBox();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEmpresas
            // 
            this.listEmpresas.FormattingEnabled = true;
            this.listEmpresas.Location = new System.Drawing.Point(12, 12);
            this.listEmpresas.Name = "listEmpresas";
            this.listEmpresas.Size = new System.Drawing.Size(272, 212);
            this.listEmpresas.TabIndex = 0;
            this.listEmpresas.DoubleClick += new System.EventHandler(this.listEmpresas_DoubleClick);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Location = new System.Drawing.Point(12, 258);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(75, 39);
            this.btnCrearEmpresa.TabIndex = 1;
            this.btnCrearEmpresa.Text = "Nueva Empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(112, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 39);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Seleccionar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(209, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 39);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSeleccionCliente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(296, 309);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.listEmpresas);
            this.Name = "frmSeleccionCliente";
            this.Text = "Seleccion de Cliente";
            this.Activated += new System.EventHandler(this.frmSeleccionCliente_Activated);
            this.Load += new System.EventHandler(this.frmSeleccionCliente_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.frmSeleccionCliente_GiveFeedback);
            this.Enter += new System.EventHandler(this.frmSeleccionCliente_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listEmpresas;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}