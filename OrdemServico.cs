using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProjetoSenac
{
    public class OrdemServico
    {
        public int CODIGOOS { get; set; }
        public int CODIGOPRODUTO { get; set; }

        public string NOMEPRODUTO { get; set; }

        public int QUANTIDADEPECA { get; set; }



        public List<string> listaSuspensa()
        {
            List<string> listaPecas = new List<string>();
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "SELECT codigoProduto FROM tbcadastropeca";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                {



                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string codigo = reader["codigoProduto"].ToString();
                                listaPecas.Add(codigo); // Adiciona o código na lista
                            }


                        }



                    }
                    // Se QUALQUER coisa der errado lá no 'try'
                    catch (Exception)
                    {
                        // Caso dê algum erro de conexão, tratamos aqui para não travar o sistema
                        MessageBox.Show("Erro ao conectar ao banco de dados.");
                    }
                }
            }

            return listaPecas;

        }




    }
}

