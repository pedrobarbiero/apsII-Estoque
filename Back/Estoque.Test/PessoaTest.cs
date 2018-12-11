using Estoque.DAL.Entities;
using Estoque.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estoque.Test
{
    [TestClass]
    public class PessoaTest
    {
        [TestMethod]
        public void NaoPodeInserirNomeMaiorQueDez()
        {
            var pessoa = new Pessoa
            {
                Nome = "PEDRO HENRIQUE BARBIERO"
            };
           
            Assert.

        }
    }
}
