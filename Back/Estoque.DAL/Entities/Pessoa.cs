using Common.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estoque.DAL.Entities
{
    public class Pessoa: Entity
    {
        [TextField]
        public string Nome { get; set; }
        public long EnderecoId { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Endereco Endereco { get; set; }
        public virtual ICollection<Telefone>Telefones { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
}
