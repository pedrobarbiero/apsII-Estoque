using System.Collections.Generic;

namespace Estoque.DAL.Entities
{
     public class Cidade : Entity 
    {
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
