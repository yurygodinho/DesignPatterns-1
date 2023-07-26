using CursoDesignPatterns._5_State.EstadosContaBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ContaBanco
    {
        public double Saldo { get;  set; }
        public string Nome { get;  set; }
        public string Numero { get;  set; }
        public string Agencia { get;  set; }
        public DateTime DataAbertura { get;  set; }
        public IEstadoDaConta Estado;

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        public ContaBanco(string nome, double saldo)
        {
            this.Saldo = saldo;
            this.Nome = nome;
        }

        public void AddSaldo(double retorno)
        {
            Saldo += retorno;
        }

    }
}
