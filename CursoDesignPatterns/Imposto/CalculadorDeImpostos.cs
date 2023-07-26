using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Desconto;

namespace CursoDesignPatterns.Imposto
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Impostos imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine(valorImposto);
        }
    }
}
