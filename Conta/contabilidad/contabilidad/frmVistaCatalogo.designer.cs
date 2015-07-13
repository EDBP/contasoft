namespace contabilidad
{
    partial class frmVistaCatalogo
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
            this.trl = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.trl)).BeginInit();
            this.SuspendLayout();
            // 
            // trl
            // 
            this.trl.Location = new System.Drawing.Point(0, 2);
            this.trl.Name = "trl";
            this.trl.OptionsPrint.UsePrintStyles = true;
            this.trl.Size = new System.Drawing.Size(516, 307);
            this.trl.TabIndex = 3;
            // 
            // frmVistaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 351);
            this.Controls.Add(this.trl);
            this.Name = "frmVistaCatalogo";
            this.Text = "frmVistaCatalogo";
            this.Load += new System.EventHandler(this.frmVistaCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList trl;


    }
}