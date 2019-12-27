using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class ContaVO : PadraoVO
    {
        public int UsuarioID { get; set; }
        public int BancoID { get; set; }
        public int TipoContaID { get; set; }
        public double Saldo { get; set; }
        public double TotalProjetado { get; set; }
    }
}
