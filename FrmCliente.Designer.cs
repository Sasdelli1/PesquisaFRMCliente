
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
            this.Dados = new System.Windows.Forms.GroupBox();
            this.nome = new System.Windows.Forms.Label();
            this.contato = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.credito = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.ButtonIncluir = new System.Windows.Forms.Button();
            this.ButtonAlterar = new System.Windows.Forms.Button();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.TextBoxContato = new System.Windows.Forms.TextBox();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).BeginInit();
            this.Dados.SuspendLayout();
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
            this.TextPesquisa.Size = new System.Drawing.Size(345, 20);
            this.TextPesquisa.TabIndex = 1;
            // 
            // ButtomPesquisa
            // 
            this.ButtomPesquisa.Location = new System.Drawing.Point(518, 15);
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
            this.DgCliente.Size = new System.Drawing.Size(569, 353);
            this.DgCliente.TabIndex = 3;
            this.DgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.TextBoxID);
            this.Dados.Controls.Add(this.TextBoxValor);
            this.Dados.Controls.Add(this.TextBoxEndereco);
            this.Dados.Controls.Add(this.TextBoxContato);
            this.Dados.Controls.Add(this.TextNome);
            this.Dados.Controls.Add(this.ButtonExcluir);
            this.Dados.Controls.Add(this.ButtonAlterar);
            this.Dados.Controls.Add(this.ButtonIncluir);
            this.Dados.Controls.Add(this.id);
            this.Dados.Controls.Add(this.credito);
            this.Dados.Controls.Add(this.endereco);
            this.Dados.Controls.Add(this.contato);
            this.Dados.Controls.Add(this.nome);
            this.Dados.Location = new System.Drawing.Point(651, 62);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(439, 353);
            this.Dados.TabIndex = 4;
            this.Dados.TabStop = false;
            this.Dados.Text = "Dados";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(54, 49);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // contato
            // 
            this.contato.AutoSize = true;
            this.contato.Location = new System.Drawing.Point(45, 85);
            this.contato.Name = "contato";
            this.contato.Size = new System.Drawing.Size(44, 13);
            this.contato.TabIndex = 1;
            this.contato.Text = "Contato";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(36, 116);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(53, 13);
            this.endereco.TabIndex = 2;
            this.endereco.Text = "Endereço";
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Location = new System.Drawing.Point(7, 147);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(82, 13);
            this.credito.TabIndex = 3;
            this.credito.Text = "Valor do Credito";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(71, 177);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 4;
            this.id.Text = "ID";
            // 
            // ButtonIncluir
            // 
            this.ButtonIncluir.Location = new System.Drawing.Point(74, 275);
            this.ButtonIncluir.Name = "ButtonIncluir";
            this.ButtonIncluir.Size = new System.Drawing.Size(75, 23);
            this.ButtonIncluir.TabIndex = 5;
            this.ButtonIncluir.Text = "Incluir";
            this.ButtonIncluir.UseVisualStyleBackColor = true;
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.Location = new System.Drawing.Point(201, 275);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAlterar.TabIndex = 6;
            this.ButtonAlterar.Text = "Alterar";
            this.ButtonAlterar.UseVisualStyleBackColor = true;
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.Location = new System.Drawing.Point(324, 275);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(75, 23);
            this.ButtonExcluir.TabIndex = 7;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = true;
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(123, 42);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(276, 20);
            this.TextNome.TabIndex = 8;
            // 
            // TextBoxContato
            // 
            this.TextBoxContato.Location = new System.Drawing.Point(123, 78);
            this.TextBoxContato.Name = "TextBoxContato";
            this.TextBoxContato.Size = new System.Drawing.Size(276, 20);
            this.TextBoxContato.TabIndex = 9;
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(123, 109);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(276, 20);
            this.TextBoxEndereco.TabIndex = 10;
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Location = new System.Drawing.Point(123, 140);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(276, 20);
            this.TextBoxValor.TabIndex = 11;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(123, 174);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(276, 20);
            this.TextBoxID.TabIndex = 12;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.DgCliente);
            this.Controls.Add(this.ButtomPesquisa);
            this.Controls.Add(this.TextPesquisa);
            this.Controls.Add(this.Text);
            this.Name = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).EndInit();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox TextPesquisa;
        private System.Windows.Forms.Button ButtomPesquisa;
        private System.Windows.Forms.DataGridView DgCliente;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.Button ButtonAlterar;
        private System.Windows.Forms.Button ButtonIncluir;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label credito;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label contato;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.TextBox TextBoxEndereco;
        private System.Windows.Forms.TextBox TextBoxContato;
        private System.Windows.Forms.TextBox TextNome;
    }
}

