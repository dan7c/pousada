using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.BancoDados;
using Pousada.Consumiveis;
using Pousada.Entidades;

namespace Pousada.Strategy
{
    public class CheckOut : IStrategy
    {
        double taxaServicos;
        double precoFinal;
        Quarto _quarto;

        public CheckOut()
        {
            System.Console.WriteLine(" --- CHECK OUT --- ");
        }

        public void Procedimento(Quarto quarto)
        {
            FecharConta(quarto);
        }

        public void FecharConta(Quarto quarto)
        {
            taxaServicos = 0.05;
            precoFinal = 0;

            _quarto = quarto;
            precoFinal = GastoPorQuarto(_quarto) * taxaServicos;

            ImprimeNota(_quarto);


            _quarto.Desocupar();
        }

        public double GastoPorQuarto(Quarto quarto)
        {
            double preco = 0;
            foreach (Hospede hospede in quarto.Hospedes)
            {
                preco += hospede.PrecoOpcionais();
            }

            preco += quarto.PrecoDiaria;
            preco *= quarto.TempoEstadia;
            preco *= (1 + taxaServicos);

            return preco;
        }

        public void ImprimeNota(Quarto quarto)
        {
            System.Console.WriteLine(quarto.Descricao);
            System.Console.WriteLine($"Gasto por hospede: ");
            foreach( Hospede hospede in quarto.Hospedes)
            {
                System.Console.WriteLine($"- Hospede: {hospede.Nome}");
                foreach (IOpcionais opcional in hospede.Opcionais)
                {
                    System.Console.WriteLine($"{opcional.Titulo} = R${opcional.PrecoDiario} X {quarto.TempoEstadia} DIAS = {opcional.PrecoDiario * quarto.TempoEstadia}");
                }
                
            }
            System.Console.WriteLine($"TAXA DE SERVICO = {taxaServicos*100}%"); 
            System.Console.WriteLine($"PRECO TOTAL = R${GastoPorQuarto(quarto)}");

        }


    }
}
