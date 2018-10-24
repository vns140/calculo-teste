using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculo_teste
{
    [TestClass]
    public class UnitTest1
    {
        private decimal valorTotal = 100000;

        [TestMethod]
        public void TestMethod1()
        {
            Proposta proposta = new Proposta { ValorVeiculo = 20000 };
            
            Assert.IsFalse(valorTotal < proposta.ValorVeiculo,"Valor do veiculo não pode ser financiado");

        }

        public static IEnumerable<InvestidorGrupoA> ObterInvestidores()
        {
            yield return new InvestidorGrupoA { Nome = "Gustavo", Valor = 10000 };
            yield return new InvestidorGrupoA { Nome = "Vinicius", Valor = 10000 };
            yield return new InvestidorGrupoA { Nome = "Sonia", Valor = 10000 };

        }
    }

    public class InvestidorGrupoA
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }

    public class Proposta
    {
        public decimal ValorVeiculo { get; set; }
    }


}
