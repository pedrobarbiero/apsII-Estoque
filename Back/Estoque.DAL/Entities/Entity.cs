using System.ComponentModel.DataAnnotations;

namespace Estoque.DAL.Entities
{
    public abstract class Entity
    {
        public ulong Id { get; set; }
    }
}
