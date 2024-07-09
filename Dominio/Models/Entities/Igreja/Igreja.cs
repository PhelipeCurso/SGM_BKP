using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models.Entities.Igreja
{
    public class Igreja : Entidade
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cnpj { get; set; }
        public string Complemento { get; set; }
        public string Presidente { get; set; }
        public string Contato { get; set; }
    }
}
