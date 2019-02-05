using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.Entities
{
    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
    }
}
