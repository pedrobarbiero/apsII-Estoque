namespace Estoque.DAL.Entities
{
    public class Pessoa: Entity
    {
        public string Nome { get; set; }

        public string Celular { get; set; }

        public long? CidadeId { get; set; }

        public string Email { get; set; }

        public virtual Cidade Cidade { get; set; }

    }
}
