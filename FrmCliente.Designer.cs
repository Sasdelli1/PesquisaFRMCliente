
namespace PesquisaCliente
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = new System.Windows.Forms.Label();
            this.TextPesquisa = new System.Windows.Forms.TextBox();
            this.ButtomPesquisa = new System.Windows.Forms.Button();
            this.DgCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(21, 20);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(129, 13);
            this.Text.TabIndex = 0;
            this.Text.Text = "Informe dado de pesquisa";
            this.Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextPesquisa
            // 
            this.TextPesquisa.Location = new System.Drawing.Point(156, 17);
            this.TextPesquisa.Name = "TextPesquisa";
            this.TextPesquisa.Size = new System.Drawing.Size(504, 20);
            this.TextPesquisa.TabIndex = 1;
            // 
            // ButtomPesquisa
            // 
            this.ButtomPesquisa.Location = new System.Drawing.Point(691, 15);
            this.ButtomPesquisa.Name = "ButtomPesquisa";
            this.ButtomPesquisa.Size = new System.Drawing.Size(75, 23);
            this.ButtomPesquisa.TabIndex = 2;
            this.ButtomPesquisa.Text = "Pesquisar";
            this.ButtomPesquisa.UseVisualStyleBackColor = true;
            this.ButtomPesquisa.Click += new System.EventHandler(this.ButtomPesquisa_Click);
            // 
            // DgCliente
            // 
            this.DgCliente.AllowUserToAddRows = false;
            this.DgCliente.AllowUserToDeleteRows = false;
            this.DgCliente.AllowUserToOrderColumns = true;
            this.DgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCliente.Location = new System.Drawing.Point(24, 62);
            this.DgCliente.Name = "DgCliente";
            this.DgCliente.ReadOnly = true;
            this.DgCliente.Size = new System.Drawing.Size(742, 353);
            this.DgCliente.TabIndex = 3;
            this.DgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgCliente);
            this.Controls.Add(this.ButtomPesquisa);
            this.Controls.Add(this.TextPesquisa);
            this.Controls.Add(this.Text);
            this.Name = "Form1";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox TextPesquisa;
        private System.Windows.Forms.Button ButtomPesquisa;
        private System.Windows.Forms.DataGridView DgCliente;
    }
}

