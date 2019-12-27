using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class CategoriaGastosVO : PadraoVO
    {
        public string Descricao { get; set; }        
        public int InOut { get; set; }
    }
}
