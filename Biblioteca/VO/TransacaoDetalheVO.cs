using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class TransacaoDetalheVO : PadraoVO
    {
        public int TranId { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Dia { get; set; }
        public int CatGastosId { get; set; }
    }
}
