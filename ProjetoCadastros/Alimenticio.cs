using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastros
{
    public class Alimenticio : Produtos
    {
        public string id { get; set; }
        public string Medida { get; set; }
        public string Tipo { get; set; }    
    }
}
