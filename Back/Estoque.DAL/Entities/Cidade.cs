﻿using Common.Attributes;

namespace Estoque.DAL.Entities
{
    public class Cidade : Entity 
    {
        [TextField]
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public virtual Estado Estado { get; set; }        
    }
}
