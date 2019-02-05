using Common.Attributes;
using Estoque.Entities;
using System.Collections.Generic;

namespace Estoque.Entities
{
    public class Cidade : Entity 
    {
        [TextField]
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public virtual Estado Estado { get; set; }        
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
