using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._3_Template
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Impostos outroImposto) : base(outroImposto) { }
        public IHIT() : base() { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> nomeItens = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (nomeItens.Contains(item.Nome))
                    return true;
                else
                    nomeItens.Add(item.Nome);
            }

            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
