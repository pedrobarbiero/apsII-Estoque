using System.ComponentModel.DataAnnotations;

namespace Estoque.DAL.Entities
{
    public class Pessoa: Entity
    {
        [Required]
        [MaxLength(10)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
