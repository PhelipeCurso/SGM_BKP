using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models.Entities.Pessoa
{
    public class Membro : Entidade
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string Complemento { get; set; }
        public string Contato { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoMembro { get; set; } // Pastor, Obreiro, Diacono, Diaconisa


    }
}
