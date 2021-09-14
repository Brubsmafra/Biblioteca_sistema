using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca_sistema
{
    public partial class FormBiblioteca_sistema : Form
    {
        public FormBiblioteca_sistema()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder ConexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "sistema_biblioteca";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;

        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void limparCampos()

        {
            textBoxCategoria.Clear();
            textBoxDescricao.Clear();
            textBoxEditora.Clear();
            textBoxStatus.Clear();
            textBoxAutor.Clear();
            textBoxNome.Clear();

        }


        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgsistema_biblioteca.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgsistema_biblioteca.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//AUTOR
                    row.Cells[3].Value = reader.GetString(3);//EDITORA
                    row.Cells[4].Value = reader.GetString(4);//CATEGORIA    
                    row.Cells[5].Value = reader.GetString(5);//DESCCRIÇÃO    
                    row.Cells[6].Value = reader.GetString(6);//STATUS
                    dgsistema_biblioteca.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO LIVRO (NOME_LIVRO, AUTOR_LIVRO, EDITORA_LIVRO, CATEGORIA_LIVRO, DESCRICAO_LIVRO, STATUS_LIVRO) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxAutor.Text + "','" + textBoxEditora.Text + "', '" + textBoxCategoria.Text + "' , '" + textBoxDescricao.Text + "' , '" + textBoxStatus.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();

                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
