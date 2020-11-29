using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pousada
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            System.Console.WriteLine(" [1] LISTAR QUARTOS VAGOS ");
            System.Console.WriteLine(" [2] NOVA RESERVA ");
            System.Console.WriteLine(" [3] FECHAR RESERVA ");
            System.Console.WriteLine(" [4] RELATORIO DE QUARTOS ");
            System.Console.Write(" OPÇAO: ");
        }

        public static void Titulo()
        {
            System.Console.WriteLine(" ----- POUSADA UVV ----- \n");
        }
    }
}
