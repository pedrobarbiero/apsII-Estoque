using System;
using System.ComponentModel.DataAnnotations;

namespace Estoque.DAL.Entities
{
    public class Pessoa: Entity
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        public string Endereco { get; set; }

        public long CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
