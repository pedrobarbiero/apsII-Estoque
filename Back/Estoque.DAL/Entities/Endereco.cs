using Common.Attributes;
using Estoque.DAL.Entities.Enums;

namespace Estoque.DAL.Entities
{
    public class Endereco: Entity
    {
        public TipoEndereco Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }        
        [TextField]
        public string Descricao { get { return $"{Logradouro}, {Bairro}, {Numero}"; } }

    }
}
