using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewerDotNet
{
    public partial class frmRelatorio : Form
    {
        private DataTable dtCliente;

        public frmRelatorio(DataTable dataTable)
        {
            InitializeComponent();
            dtCliente = dataTable;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            this.relatorioCliente.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("datasetCliente", dtCliente));
            this.relatorioCliente.RefreshReport();
        }
    }
}
