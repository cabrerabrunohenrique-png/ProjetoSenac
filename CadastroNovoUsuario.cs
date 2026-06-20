using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs;
// tem que instalar o MySqlConnector
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace ProjetoSenac
{
    public partial class CadastroNovoUsuario : Form

    {

        ErrorProvider errorProvider = new ErrorProvider();
        TaskDialog taskDialog = new TaskDialog();




        //Comando para criar uma lista
        //No caso eu estou criando uma lista do tipo CadastroUsuario, que é a CLASSE que
        //eu criei para receber os dados do banco de dados
        BindingList<CadastroUsuario> listaCadastroUsuario = new BindingList<CadastroUsuario>();


        public CadastroNovoUsuario()
        {
            InitializeComponent();

            cbNivelPermisao.Items.Add("Administrador");
            cbNivelPermisao.Items.Add("Usuário Comum");
            cbNivelPermisao.Items.Add("Usuário Restrito");

            

         


        }

        const string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

        private void btVoltarCNU_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            //DialogResult = DialogResult.OK;
            DialogResult resposta = MessageBox.Show("Deseja realmente voltar para a tela de login?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            errorProvider.SetError(txNomeCompleto, "");
            string nomeCompleto = txNomeCompleto.Text.Trim(); 
            string numeroRegistro = txNumeroRegistro.Text;
            string nivelPermissao = cbNivelPermisao.Text;
            string nomeUsuario = txNomeUsuario.Text.Trim();
            string senhaAcesso = txSenhaAcesso.Text;
            
            //DateTime dateTime = DateTime.Now;


            int controleLinhasAftadas = 0;

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";



            errorProvider.SetError(txNomeCompleto, "");

            if (nomeCompleto.Length < 5 || nomeCompleto.Length > 50)
            {
                errorProvider.SetError(txNomeCompleto, "O nome completo deve ter entre 5 e 50 caracteres.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O nome inserido deve conter entre 5 e 50 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                //MessageBox.Show("O nome completo deve ter entre 5 e 50 caracteres.", "NOME COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                


                return;
            }

            
            

            else if (nomeCompleto.Split(' ').Length <2)
            {

                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O nome completo deve conter pelo menos um sobrenome.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                //MessageBox.Show("O nome completo deve conter pelo menos um sobrenome.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
            }

           

            
            
            else if (nomeCompleto.Any(c => char.IsDigit(c)))

             {
                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O campo nome completo não pode conter números.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
            
            }

            

             else if (nomeCompleto.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
            {
                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O campo nome completo não pode conter caracteres especiais.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto .Focus();
                return;
            }

            else
            {
                
                    errorProvider.SetError(txNomeCompleto, string.Empty);
                    errorProvider.Clear();
                

            }

            if(string.IsNullOrWhiteSpace(numeroRegistro))
            {
                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Registro incompleto";
                taskDialog.Text = "Todos os campos devem ser preenchidos.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroRegistro.Focus();
                txNumeroRegistro.Clear();

                //MessageBox.Show("Todos os campos devem ser preenchidos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char[] numeroValidado = numeroRegistro.ToCharArray();

              if (numeroRegistro.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsLetter(c)))
            {
                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Numero ja Cadastrado";
                taskDialog.Text = "Só pode NUMERO INTEIRO POSITIVO.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroRegistro.Clear();
                txNumeroRegistro.Focus();
                return;


                
            }

            if (numeroRegistro.Length >10 )
            {
                MessageBox.Show(" Numero nao pode ter mais que 10 casas ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNumeroRegistro.Clear();
                return;
            }

            
            
            if (nomeUsuario.Length >10)
            {
                MessageBox.Show("Nome de usuário nao pode ser maior que 10 caracteres", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomeUsuario.Clear();
                return;
            }


           if (string.IsNullOrEmpty(numeroRegistro) || string.IsNullOrEmpty(nivelPermissao) || string.IsNullOrEmpty(nomeUsuario)
            || string.IsNullOrEmpty(senhaAcesso) || string.IsNullOrEmpty(txConfirmacaoSenha.Text))
            {
                
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Registro incompleto";
                taskDialog.Text = "Todos os campos devem ser preenchidos.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                //MessageBox.Show("Todos os campos devem ser preenchidos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }


            if (listaCadastroUsuario.Any(c => c.NOMECOMPLETO == nomeCompleto))
            {
                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome ja cadastrado";
                taskDialog.Text = "O NOME COMPLETO" + nomeCompleto+ " já possui registro. Nao é permitido duplicidade de NOME COMPLETO.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
            }


            if (listaCadastroUsuario.Any(c => c.NUMEROREGISTRO == numeroRegistro))
            {

                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Numero ja Cadastrado";
                taskDialog.Text = "O NUMERO DE REGISTRO" + numeroRegistro + " já possui registro. Nao é permitido duplicidade de NUMERO DE REGISTRO.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
                
            }

            if (listaCadastroUsuario.Any(c => c.NOMEUSUARIO == nomeUsuario))
            {
                MessageBox.Show("O NOME DE USUARIO" + nomeUsuario + " já existe. Por favor, escolha outro.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                txNomeUsuario.Clear();
                return;

            }
            
            if(senhaAcesso != txConfirmacaoSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txSenhaAcesso.Clear();
                txConfirmacaoSenha.Clear();
                return;
            }


                else
                {
                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    conn.Open();
                    // tem que colocar esse comando para conecatar com o banco criado
                    //value @---serve para passar o valor do campo do formulario para o banco de dados
                    string scriptInsert = "INSERT INTO tbcadastronovousuario " +
                        "(nomeCompleto,numeroRegistro,nivelPermisao,nomeUsuario,senhaAcesso)" +
                        " VALUE(@nomeCompleto,@numeroRegistro,@nivelPermisao,@nomeUsuario,@senhaAcesso)";


                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
                        comando.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);
                        comando.Parameters.AddWithValue("@nivelPermisao", nivelPermissao);
                        comando.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                        comando.Parameters.AddWithValue("@senhaAcesso", senhaAcesso);


                        controleLinhasAftadas = comando.ExecuteNonQuery();
                    }

                    CadastroUsuario cadastroUsuario = new CadastroUsuario();
                    cadastroUsuario.NOMECOMPLETO = nomeCompleto;
                    cadastroUsuario.NUMEROREGISTRO = numeroRegistro;
                    cadastroUsuario.NIVELPERMISSAO = nivelPermissao;
                    cadastroUsuario.NOMEUSUARIO = nomeUsuario;
                    cadastroUsuario.SENHAACESSO = senhaAcesso;
                    listaCadastroUsuario.Add(cadastroUsuario);


                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txNomeCompleto.Clear();
                    txNumeroRegistro.Clear();
                    cbNivelPermisao.SelectedIndex = -1;
                    txNomeUsuario.Clear();
                    txSenhaAcesso.Clear();
                    txConfirmacaoSenha.Clear();
                    conn.Close();

                }
            }
        }
        /*if (controleLinhasAftadas > 0){MessageBox.Show("Cadastro realizado com sucesso!");}*/


        private void lNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void CadastroNovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txSenhaAcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
