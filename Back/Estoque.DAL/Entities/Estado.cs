using System.Collections.Generic;

namespace Estoque.DAL.Entities
{
    public class Estado : Entity
    {
        public string Nome { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
