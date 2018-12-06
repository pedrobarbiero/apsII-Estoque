using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.DAL.Entities
{
    public interface ITesteRepository: IRepository<Teste>
    {
        string TesteDescricao();
    }
}
