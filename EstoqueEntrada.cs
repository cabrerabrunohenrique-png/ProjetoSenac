using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProjetoSenac
{
    public class EstoqueEntrada
    {

        public int CODIGOPECA { get; set; }
        public string NOMEPECA { get; set; }


        public int QUANTIDADEPECA { get; set; }

        public int NUMERONF { get; set; }

        public DateTime DATAENTRADA { get; set; }

        

        public double fncalculartotal()
        {
            return QUANTIDADEPECA;
        }

        public double totalgeral;

        public void fcalcularTotal()
        {
            totalgeral = QUANTIDADEPECA; 
        }


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




        public bool FcValidarCodigoProduto(int codigoPeca, string nomepeca)
        {
            bool errado = false;
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "select * from tbcadastropeca where codigoProduto =@codigoProduto and nomeproduto =@nomeProduto";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            
            using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
            {
                comando.Parameters.AddWithValue("@codigoProduto", codigoPeca);
                comando.Parameters.AddWithValue("@nomeProduto", nomepeca);


                try
                {
                    conn.Open();
                    int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                    errado = (quantidade > 0);

                }
                // Se QUALQUER coisa der errado lá no 'try'
                catch (Exception)
                {
                    // Caso dê algum erro de conexão, tratamos aqui para não travar o sistema
                    errado = false;
                }

                return errado;


            }







        } 

        public bool validarEntradas(int codigoPeca, int numeroNf, int quanitadePeca)
        {
            bool existeNoBanco = false;
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "SELECT COUNT(*) FROM tbentradaestoque WHERE codigoProduto = @codigoProduto AND nFProduto = @nFProduto and quantidadeProduto = @quantidadeProduto";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                {
                    comando.Parameters.AddWithValue("@codigoProduto", codigoPeca);
                    comando.Parameters.AddWithValue("@nFProduto", numeroNf);
                    comando.Parameters.AddWithValue("@quantidadeProduto", quanitadePeca);

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
