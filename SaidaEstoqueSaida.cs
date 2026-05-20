using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenac
{
    public class SaidaEstoqueSaida
    {
        public DateTime DATA_SAIDA {  get; set; }

        public int CODIGOPECA { get; set; }

        public string NOMEPECA { get; set; }

        public int QUANTIDADEPECA { get; set; }
        public int NUMERONF { get; set; }

        public int CPFPECA { get; set; }

        public int NUMEROOS { get; set; }

        public string SITUACAO { get; set; }
    }
}
