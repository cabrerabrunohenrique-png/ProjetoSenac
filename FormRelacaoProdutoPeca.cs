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
    public partial class FormRelacaoProdutoPeca : Form
    {
        public FormRelacaoProdutoPeca()
        {
            InitializeComponent();
        }

            private void btVoltarOS_Click(object sender, EventArgs e)
            {
            this.Owner.Show();
            this.Close();   








            /*FormRelacaoProdutoPeca formRelacaoProdutoPeca = new FormRelacaoProdutoPeca();
            Nav formNav = new Nav();
            formNav.Owner = this;
            // Quando o formRelacaoProdutoPeca fechar, executa o código para mostrar este form de novo
            formRelacaoProdutoPeca.FormClosed += (s, args) => this.Show();
            this.Show();*/

        }
    }
}
