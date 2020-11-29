using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.BancoDados;
using Pousada.Entidades;
using Pousada.Strategy;

namespace Pousada.Facade
{
    public class Fachada
    {
        public static void ListarQuartos()
        {
            Queries.ListarQuartosVagos();
        }

        public static void NovaReserva()
        {
            ListarQuartos();
            System.Console.Write(" INFORME O NUMERO DO QUARTO QUE DESEJA RESERVAR: ");
            int numero = Convert.ToInt32(System.Console.ReadLine());
            Quarto quarto = Queries.GetQuartoPorNum(numero);

            IStrategy checkIn = new CheckIn();
            checkIn.Procedimento(quarto);
        }

        public static void FecharReserva()
        {
            System.Console.Write(" INFORME O NUMERO DO QUARTO QUE DESEJA FECHAR A RESERVA: ");
            int numero = Convert.ToInt32(System.Console.ReadLine());
            Quarto quarto = Queries.GetQuartoPorNum(numero);

            IStrategy checkOut = new CheckOut();
            checkOut.Procedimento(quarto);
        }

        public static void Relatorio()
        {
            IStrategy relatorio = new Relatorio();
            foreach (KeyValuePair<int, Quarto> q in DB.dbQuartos)
            {
                relatorio.Procedimento(q.Value);
            }
        }

      

    }
}
