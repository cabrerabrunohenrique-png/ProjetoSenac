using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenac
{
    public class OrdemServico
    {
        public int CODIGOOS { get; set; }
        public int CODIGOPRODUTO { get; set; }

        public string NOMEPRODUTO { get; set; }
    }
}
