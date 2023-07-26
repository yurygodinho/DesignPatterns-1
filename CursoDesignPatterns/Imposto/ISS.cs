using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Desconto;

namespace CursoDesignPatterns
{
    public class ISS : Impostos
    {
        public ISS(Impostos outroImposto) : base(outroImposto) { }
        public ISS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }


    }
}
