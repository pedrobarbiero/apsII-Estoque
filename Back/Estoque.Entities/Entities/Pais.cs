using Common.Attributes;
using Estoque.Entities;
using System.Collections.Generic;

namespace Estoque.Entities
{
    public class Pais: Entity
    {
        [TextField]
        public string Nome { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
