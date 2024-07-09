using Dominio.Comuns;
using Dominio.Models.Entities.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models.Entities.Financeiro
{
    public class Financeiro : Entidade
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; } // Oferta, Dizimo, Despesa
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int? MembroId { get; set; }
        public Membro Membro { get; set; }
    }
}
