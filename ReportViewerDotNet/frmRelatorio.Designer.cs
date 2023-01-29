namespace ReportViewerDotNet
{
    partial class frmRelatorio
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
            this.relatorioCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // relatorioCliente
            // 
            this.relatorioCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatorioCliente.LocalReport.ReportEmbeddedResource = "reportViewerteste.Clientes.rdlc";
            this.relatorioCliente.Location = new System.Drawing.Point(0, 0);
            this.relatorioCliente.Name = "relatorioCliente";
            this.relatorioCliente.ServerReport.BearerToken = null;
            this.relatorioCliente.Size = new System.Drawing.Size(535, 450);
            this.relatorioCliente.TabIndex = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.relatorioCliente);
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioCliente;
    }
}