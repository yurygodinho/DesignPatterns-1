using CursoDesignPatterns._1_Strategy.ICCC;
using CursoDesignPatterns._3_Template;
using CursoDesignPatterns._4_Decorator;
using CursoDesignPatterns._6_Builder;
using CursoDesignPatterns._7_Observer;
using CursoDesignPatterns._7_Observer.ObservadorMultiplicador;
using CursoDesignPatterns.Desconto;
using CursoDesignPatterns.Imposto;
using CursoDesignPatterns.Modulo7.Desafio2;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Orcamento orcamento = new Orcamento(500);

            #region ISS e ICMS
            Console.WriteLine("\nImpostos: \n");
            Impostos iss = new ISS(new ICMS());

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            #endregion ISS e ICMS

            #region ICCC
            Console.WriteLine("\nICCC: \n");
            Impostos novoImposto = new ICCC();
            Console.WriteLine(novoImposto.Calcula(orcamento));
            #endregion ICCC

            #region Desconto
            Console.WriteLine("\nDesconto: \n");
            CalculadorDeDescontos calculadorDesc = new CalculadorDeDescontos();

            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));

            double desconto = calculadorDesc.Calcula(orcamento);

            Console.WriteLine(desconto);

            #endregion Desconto

            #region Responsability
            Console.WriteLine("\nResponsability: \n");

            CursoDesignPatterns.Desconto.CalculadorDeDescontos calculadorResp = new CursoDesignPatterns.Desconto.CalculadorDeDescontos();
            double descontoResp = calculadorResp.Calcula(orcamento);

            Console.WriteLine("Calculando desconto: " + descontoResp);
            #endregion Responsability

            #region Template
            Console.WriteLine("\nTemplate: \n");

            TemplateDeImpostoCondicional icpp = new ICPP();
            TemplateDeImpostoCondicional ikvc = new IKCV();

            Console.WriteLine("Calculando ICPP: " + icpp.Calcula(orcamento));
            Console.WriteLine("Calculando IKVC: " + ikvc.Calcula(orcamento));


            #endregion Template

            #region Decorator
            Console.WriteLine("\nDecorator: \n");

            Impostos impostos = new ImpostoMuitoAlto(new IHIT());

            Console.WriteLine(impostos.Calcula(orcamento));

            #endregion Decorator

            #region State
            Console.WriteLine("\nState: \n");

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();
            #endregion State

            #region Builder
            Console.WriteLine("\nBuilder: \n");
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("26.456.789/0001-12")
                .Com(new ItemDaNota("Item 1", 100))
                .Com(new ItemDaNota("Item 2", 200))
                .ComObservacoes("uma obs qualquer");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            #endregion Builder

            #region Observer
            Console.WriteLine("\nObserver: \n");

            NotaFiscalBuilderObserver builder = new NotaFiscalBuilderObserver();
            builder.AdicionaAcao(new EnviadorDeEmail());
            builder.AdicionaAcao(new NotaFiscalDAO());
            builder.AdicionaAcao(new EnviaDeSMS());
            builder.AdicionaAcao(new Multiplicador(2));
            builder.AdicionaAcao(new Multiplicador(3));
            builder.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .Com(new ItemDaNota("item 1", 100))
                              .Com(new ItemDaNota("item 2", 200))
                              .Com(new ItemDaNota("item 3", 300))
                              .ComObservacoes("entregar notaFiscal pessoalmente")
                              .Constroi();

            #endregion Observer


        }
    }
}