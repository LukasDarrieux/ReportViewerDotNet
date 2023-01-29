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
    public partial class Form1 : Form
    {
        private int Id = 0;
        private int linha = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MensagemAlertaCampo("Nome", txtNome);
                return;
            }
            if (String.IsNullOrEmpty(txtNasc.Text.Replace("/", "").Trim()))
            { 
                MensagemAlertaCampo("Nascimento", txtNasc);
                return;
            }

            using (Clientes cliente = new Clientes(++Id, txtNome.Text, txtNasc.Text))
            {
                gridClientes.Rows.Add();
                gridClientes[0, linha].Value = cliente.Id;
                gridClientes[1, linha].Value = cliente.Nome;
                gridClientes[2, linha].Value = cliente.Nascimento;
            }
                

            linha++;

        }

        private void MensagemAlertaCampo(string nomeCampo, Control campo)
        {
            MessageBox.Show($"Preencha o campo {nomeCampo}", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            campo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNasc.Clear();
            gridClientes.Rows.Clear();
            gridClientes.Rows.Add();
            Id = 0;
            linha = 0;
            txtNome.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (gridClientes[0, 0].Value is null || String.IsNullOrEmpty(gridClientes[0, 0].Value.ToString()))
            {
                MessageBox.Show("Adicione clientes primeiramente", "Tabela vazia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dtCliente = new DataTable();
            dtCliente.Columns.Add("Id", typeof(int));
            dtCliente.Columns.Add("Nome", typeof(string));
            dtCliente.Columns.Add("Nascimento", typeof(string));

            int row = 0;

            while (row < gridClientes.Rows.Count - 1)
            {
                DataRow dtRow = dtCliente.NewRow();
                dtRow[0] = gridClientes[0, row].Value;
                dtRow[1] = gridClientes[1, row].Value;
                dtRow[2] = gridClientes[2, row].Value;
                dtCliente.Rows.Add(dtRow);
                row++;
            }

            using (var frm = new frmRelatorio(dtCliente))
            {
                frm.ShowDialog();
            }
        }
    }
}
