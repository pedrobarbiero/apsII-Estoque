using Common.Attributes;
using System.Collections.Generic;

namespace Estoque.DAL.Entities
{
    public class Pais: Entity
    {
        [TextField]
        public string Nome { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
