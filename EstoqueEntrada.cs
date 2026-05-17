using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenac
{
    public class EstoqueEntrada
    {

        public int CODIGOPECA { get; set; }
        public string NOMEPECA { get; set; }
        public string FABRICANTE { get; set; }
        public double PESOPECA { get; set; }

        public double ALTURAPECA { get; set; }
        public double COMPRIMENTOPECA { get; set; }

        public int QUANTIDADEPECA { get; set; }

        public int NUMERONF { get; set; }
        
        public DateTime DATAENTRADA { get; set; }


    }
}
