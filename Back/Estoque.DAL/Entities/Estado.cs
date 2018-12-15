﻿using Common.Attributes;
using System.Collections.Generic;

namespace Estoque.DAL.Entities
{
    public class Estado : Entity
    {
        [TextField]
        public string Nome { get; set; }
        public long PaisId { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
