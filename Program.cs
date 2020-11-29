using System;
using System.Collections;
using System.Collections.Generic;
using Pousada.QFactories;
using Pousada.BancoDados;
using Pousada.Facade;

namespace Pousada
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();

            DB myDatabase = new DB();

            EscolherOpcao();

            void EscolherOpcao()
            {
                Console.Clear();
                Menu.MostrarMenu();
                int opcao = Convert.ToInt32(System.Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Fachada.ListarQuartos();
                        Console.Write("\nPressione qualquer tecla ...");
                        Console.ReadKey();
                        EscolherOpcao();
                        break;
                    case 2:
                        Fachada.NovaReserva();
                        Console.Write("\nPressione qualquer tecla ...");
                        Console.ReadKey();
        
                        EscolherOpcao();
                        break;
                    case 3:
                        Fachada.FecharReserva();
                        Console.Write("\nPressione qualquer tecla ...");
                        Console.ReadKey();
                        EscolherOpcao();
                        break;
                    case 4:
                        Fachada.Relatorio();
                        Console.Write("\nPressione qualquer tecla ...");
                        Console.ReadKey();
                        EscolherOpcao();
                        break;
                }
            }
        }
    }
}
