using CursoDesignPatterns._6_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._7_Observer.ObservadorMultiplicador
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * this.Fator);
        }
    }
}
