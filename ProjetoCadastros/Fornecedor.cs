using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastros
{
    public class Fornecedor
    {
        public string Id { get; set; }  
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string InscricaoEstadual { get; set; }

    }
}
