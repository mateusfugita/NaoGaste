using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class GastosMensaisVO : PadraoVO
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Vencimento { get; set; }
        public int UsuarioId { get; set; }
    }
}
