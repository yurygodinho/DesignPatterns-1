using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Desconto;

namespace CursoDesignPatterns
{
    public abstract class Impostos
    {
        public Impostos OutroImposto { get; set; }

        public Impostos(Impostos outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Impostos()
        {
            this.OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
