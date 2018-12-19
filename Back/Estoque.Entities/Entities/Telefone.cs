using Estoque.Entities;
using Estoque.Enums;
using System.ComponentModel.DataAnnotations;

namespace Estoque.Entities
{
    public class Telefone:Entity
    {
        public CategoriaTelefone Categoria { get; set; }
        public PropriedadeTelefone Propriedade { get; set; }
        public long PessoaId { get; set; }

        [MaxLength(15)]
        //[RegularExpression(@"^\(\d{3}\)\s{0,1}\d{3}-\d{7}$", ErrorMessage = "Número inválido")]
        public string Numero { get; set; }

        [Display(Name ="Possui Whatsapp")]
        public bool PossuiWhatsapp { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
