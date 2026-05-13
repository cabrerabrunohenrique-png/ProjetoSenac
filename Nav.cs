using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenac
{
    public partial class Nav : Form
    {


        public Nav()
        {
            InitializeComponent();

            
        }

        

        private void btPaginaLogin_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            // Para criar o comando de abrir outra aba, foi necessario criar um formulaio
            //nesse caso o Form1, entao eu chamei ele e lgo tive que
            // colocar o nome da variave que seria da variavel " FORM1".
            //Depois eu chamei o comando "new" OU SEJA sera o NOVO "Form1". Depois chamei com o comando "ShowDialog"
            //para mostrar a tela do Form1,
            //e por ultimo coloquei o comando "DialogResult" para fechar a tela do Nav e abrir a tela do Form1.
            //Form1 formLogin = new Form1();
            //formLogin.Owner = this;
            //formLogin.Show();
            //this.Hide();

        }

        private void btOrdemServico_Click(object sender, EventArgs e)
        {
            FormOrdemServico formOrdemServico = new FormOrdemServico();
            formOrdemServico.Owner = this;
            this.Hide();
            formOrdemServico.ShowDialog();
            


        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque formEstoque = new FormEstoque();
            formEstoque.Owner = this;
            this.Hide();
            formEstoque.ShowDialog();
            
            
        }

        private void btProdutoXPeca_Click(object sender, EventArgs e)
        {
            
            FormRelacaoProdutoPeca formRelacaoProdutoPeca = new FormRelacaoProdutoPeca();
            formRelacaoProdutoPeca.Owner = this;
            //formRelacaoProdutoPeca.FormClosed += (s, args) => this.Show();
            this.Hide();
            formRelacaoProdutoPeca.ShowDialog();
            



        }

        private void btAcessarRelatorioN_Click(object sender, EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio();
            formRelatorio.Owner = this;
            this.Hide();
            formRelatorio.ShowDialog();
            

        }

        private void btEstoqueSaida_Click(object sender, EventArgs e)
        {
            FormEstoqueSaida formsaida = new FormEstoqueSaida();
            formsaida.Owner = this;
            this.Hide();
            formsaida.ShowDialog();
            
        }
    }
}
