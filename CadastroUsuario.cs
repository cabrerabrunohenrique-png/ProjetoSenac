using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ProjetoSenac
{
    public class CadastroUsuario
    {
        public string NOMECOMPLETO { get; set; }
        public string NUMEROREGISTRO { get; set; }

        public string NIVELPERMISSAO { get; set; }
            
        public string NOMEUSUARIO { get; set; }

        public string SENHAACESSO { get; set; }

        public string CONFIRMARSENHA { get; set; }


        public bool validarSenha(string senha, string nomeUsuario)

        {
            bool existeNoBanco = false;
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";
            string scriptSelect = "SELECT COUNT(*) FROM tbcadastronovousuario " +
                "WHERE nomeUsuario = @nomeUsuario AND senhaAcesso = @senha";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                using (MySqlCommand comando = new MySqlCommand(scriptSelect, conn))
                {
                    comando.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                    comando.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        conn.Open();
                        int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                        existeNoBanco =(quantidade > 0);
                        
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

