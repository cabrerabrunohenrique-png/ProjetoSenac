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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Nav formNav = new Nav();
            formNav.ShowDialog();
            this.DialogResult = DialogResult.OK;
            
        }

        private void btCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            CadastroNovoUsuario formCadastro = new CadastroNovoUsuario();
            formCadastro.ShowDialog();
            DialogResult = DialogResult.OK;
        }
    }
}
