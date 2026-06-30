using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoSenac
{
    public class CadastroProduto
    {
        public int CODIGOPRODUTO { get; set; }

        public string NOMEPRODUTO { get; set; }

        public string FABRICANTEPRODUTO { get; set; }

        public double PESOPRODUTO { get; set; }

        public double ALTURAPRODUTO { get; set; }

        public double COMPRIMENTOPRODUTO { get; set; }


        public List<CadastroProduto> FcPesquisaNome(string NOMEPRODUTO)
        { 
            List<CadastroProduto> listaResultado = new List<CadastroProduto>();
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "SELECT codigoproduto, nomeProduto FROM tbcadastropeca WHERE nomeproduto = @nomeProduto";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                {
                    comando.Parameters.AddWithValue("@nomeProduto", NOMEPRODUTO);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                CadastroProduto produto = new CadastroProduto();
                                {
                                    produto.NOMEPRODUTO = reader["nomeProduto"].ToString();
                                    produto.CODIGOPRODUTO = Convert.ToInt32(reader["codigoproduto"]);

                                    listaResultado.Add(produto);
                                }

                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }

                    return listaResultado;
                }
            }

        }

       
        public bool FcValidarNome(string nomeProduto)
        {
            bool result = false;

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "SELECT COUNT(*) FROM tbcadastropeca WHERE nomeproduto = @nomeProduto";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                {
                    comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                    try
                    {
                        conn.Open();
                        int quantidade = Convert.ToInt32(comando.ExecuteScalar());
                        if (quantidade > 0)
                        {
                            result = true; // Achou o nome gravado no MySQL!
                        }
                    }
                    catch (Exception)
                    {
                        result = false;
                    }

                    return result;
                }
            }

        }
        


        public bool ValidarCodigo(int codigoProduto)
        {
                bool existeNoBanco = false;

                // Usando exatamente os mesmos dados de conexão e tabela do seu formulário
                string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
                string scriptSelect = "SELECT COUNT(*) FROM tbcadastropeca WHERE codigoproduto = @codigoProduto";

                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                    {
                        comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                        try
                        {
                            conn.Open();
                            int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                            if (quantidade > 0)
                            {
                                existeNoBanco = true; // Achou o código gravado no MySQL!
                            }
                        }
                        // Se QUALQUER coisa der errado lá no 'try'
                        catch (Exception)
                        {
                            // Caso dê algum erro de conexão, tratamos aqui para não travar o sistema
                            existeNoBanco = false;
                        }
                    }
                }

                return existeNoBanco; // Devolve True (se achou) ou False (se não achou)
            }
        }
    }


