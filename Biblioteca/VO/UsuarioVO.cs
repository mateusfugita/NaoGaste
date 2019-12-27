using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VO
{
    public class UsuarioVO : PadraoVO
    {        
        public string Nome { get; set; }
        public byte[] Foto { get; set; }
        public string Senha { get; set; }

    }
}
