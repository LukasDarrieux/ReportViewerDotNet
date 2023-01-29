namespace ReportViewerDotNet
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATANASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 15);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(607, 25);
            this.txtNome.TabIndex = 1;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(13, 46);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(40, 17);
            this.lblNasc.TabIndex = 2;
            this.lblNasc.Text = "Nasc:";
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(68, 43);
            this.txtNasc.Mask = "00/00/0000";
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(108, 25);
            this.txtNasc.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(600, 43);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.DATANASCIMENTO});
            this.gridClientes.Location = new System.Drawing.Point(16, 89);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(659, 243);
            this.gridClientes.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Width = 400;
            // 
            // DATANASCIMENTO
            // 
            this.DATANASCIMENTO.HeaderText = "DATA DE NASCIMENTO";
            this.DATANASCIMENTO.Name = "DATANASCIMENTO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(290, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(371, 351);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 32);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 406);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.MaskedTextBox txtNasc;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATANASCIMENTO;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}

