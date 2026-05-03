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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btPaginaIncialE_Click(object sender, EventArgs e)
        {
            Nav formNav = new Nav();
            this.Hide();
            formNav.Show();
            DialogResult = DialogResult.OK;
            this.Show();
        }
    }
}
