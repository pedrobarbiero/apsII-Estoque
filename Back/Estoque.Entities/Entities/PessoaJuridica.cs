using Estoque.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Estoque.Entities
{
    public class PessoaJuridica:Entity
    {
        public long PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public string Razao { get; set; }
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataFundacao { get; set; }

    }
}
