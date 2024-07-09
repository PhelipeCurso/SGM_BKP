using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comuns
{
    public abstract class Entidade
    {
        protected Entidade() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
