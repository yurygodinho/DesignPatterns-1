using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._2_Responsibility.RequisicaoWeb
{
    public class RespostaEmCSV : Resposta
    {
        public Resposta OutraResposta { get; private set; }

        public RespostaEmCSV(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, ContaBanco conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
