using System;
using System.ComponentModel.DataAnnotations;

namespace Estoque.DAL.Entities
{
    public class PessoaFisica : Entity
    {
        public long PessoaId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public Sexo Sexo { get; set; }
        public virtual Pessoa Pessoa {get;set;}
    }
}
