
namespace Biblioteca_sistema
{
    partial class FormBiblioteca_sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiblioteca_sistema));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxEditora = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgsistema_biblioteca = new System.Windows.Forms.DataGridView();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalvar = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgsistema_biblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(68, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(212, 28);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 7;
            // 
            // textBoxEditora
            // 
            this.textBoxEditora.Location = new System.Drawing.Point(364, 28);
            this.textBoxEditora.Name = "textBoxEditora";
            this.textBoxEditora.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditora.TabIndex = 8;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(528, 27);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoria.TabIndex = 9;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(880, 30);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 11;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(68, 79);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgsistema_biblioteca
            // 
            this.dgsistema_biblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsistema_biblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaAutor,
            this.ColunaEditora,
            this.ColunaCategoria,
            this.ColunaDescricao,
            this.ColunaStatus});
            this.dgsistema_biblioteca.Location = new System.Drawing.Point(27, 162);
            this.dgsistema_biblioteca.Name = "dgsistema_biblioteca";
            this.dgsistema_biblioteca.Size = new System.Drawing.Size(953, 276);
            this.dgsistema_biblioteca.TabIndex = 13;
            // 
            // ColunaID
            // 
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.Width = 30;
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 200;
            // 
            // ColunaAutor
            // 
            this.ColunaAutor.HeaderText = "Autor";
            this.ColunaAutor.Name = "ColunaAutor";
            this.ColunaAutor.Width = 150;
            // 
            // ColunaEditora
            // 
            this.ColunaEditora.HeaderText = "Editora";
            this.ColunaEditora.Name = "ColunaEditora";
            this.ColunaEditora.Width = 115;
            // 
            // ColunaCategoria
            // 
            this.ColunaCategoria.HeaderText = "Categoria";
            this.ColunaCategoria.Name = "ColunaCategoria";
            this.ColunaCategoria.Width = 115;
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.HeaderText = "Descrição ";
            this.ColunaDescricao.Name = "ColunaDescricao";
            this.ColunaDescricao.Width = 250;
            // 
            // ColunaStatus
            // 
            this.ColunaStatus.HeaderText = "Status";
            this.ColunaStatus.Name = "ColunaStatus";
            this.ColunaStatus.Width = 50;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(212, 79);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(695, 28);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(136, 20);
            this.textBoxDescricao.TabIndex = 15;
            // 
            // FormBiblioteca_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dgsistema_biblioteca);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxEditora);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBiblioteca_sistema";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FormBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsistema_biblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxEditora;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgsistema_biblioteca;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaStatus;
        private System.Windows.Forms.TextBox textBoxDescricao;
    }
}
