using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class TransacaoMestreVO : PadraoVO
    {        
        public int ContaId { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
