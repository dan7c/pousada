using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.BancoDados;
using Pousada.Entidades;

namespace Pousada.Strategy
{
    public class CheckIn : IStrategy 
    {
        public CheckIn()
        {
            System.Console.WriteLine(" --- CHECK IN --- ");
        }

        public void Procedimento(Quarto quarto)
        {
            AbrirComanda(quarto);
        }

        private void AbrirComanda(Quarto quarto){ 
        
            System.Console.WriteLine(quarto.Descricao);

            if (Queries.TestaDisponibilidade(quarto))
            {
                while (quarto.Hospedes.Count < quarto.LimiteHospedes)
                {
                    Hospede hospede = CriarHospede();
                    if (Queries.ProcuraHospede(hospede))
                    {
                        System.Console.WriteLine("HOSPEDE JÁ CADASTRADO");
                        break;
                    }
                    else
                    {
                        DB.dbHospedes.Add(hospede);
                        EscolherOpcionais(hospede);
                        quarto.Hospedes.Add(hospede);
                        hospede.Quarto = quarto;
                        System.Console.WriteLine(" INFORME O TEMPO DE ESTADIA EM DIAS: ");
                        int tempo = Convert.ToInt32(System.Console.ReadLine());
                        quarto.TempoEstadia = tempo;
                        quarto.Ocupar();
                    }

                }
            }
            else
            {
                System.Console.WriteLine("QUARTO JÁ OCUPADO. ");
            }
            
        }

        private Hospede CriarHospede()
        {
            System.Console.Clear();
            System.Console.WriteLine(" --- NOVO HOSPEDE --- ");
            System.Console.Write(" NOME: ");
            string _nome = System.Console.ReadLine();
            System.Console.Write(" RG: ");
            string _endereco = System.Console.ReadLine();

            Hospede hospede = new Hospede(_nome, _endereco);
            
            return hospede;
        }

        private void EscolherOpcionais(Hospede hospede)
        {
            System.Console.WriteLine(" DESEJA INCLUIR OPCIONAIS? [0]NENHUM [1]ALIMENTAÇAO [2]TELEFONE [3]AMBOS");
            int opcao = Convert.ToInt32(System.Console.ReadLine());

            switch( opcao)
            {
                case 0:
                    break;
                case 1:
                    hospede.AddAlimentacao();
                    break;
                case 2:
                    hospede.AddTelefone();
                    break;
                case 3:
                    hospede.AddAlimentacao();
                    hospede.AddTelefone();
                    break;
                default:
                    System.Console.Clear();
                    System.Console.WriteLine(" OPCAO INVALIDA. ESCOLHA OPCAO VALIDA: ");
                    EscolherOpcionais(hospede);
                    break;
            }
        }

    }
}