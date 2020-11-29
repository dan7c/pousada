using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;

namespace Pousada.BancoDados
{
    public class Queries
    {

        public static void ListarQuartosVagos()
        {
            System.Console.Clear();
            System.Console.WriteLine(" -- QUARTOS VAGOS: --");
            System.Console.WriteLine(" NUMERO  |  TIPO ");
            foreach (KeyValuePair<int, Quarto> quarto in DB.dbQuartos)
            {
                if (quarto.Value.Disponivel.Equals(true))
                {
                    System.Console.WriteLine($"  {quarto.Key}        {quarto.Value.TipoQuarto}");
                }
            }
        }


        public static Quarto GetQuartoPorNum( int num )
        {
            foreach ( KeyValuePair<int, Quarto> quarto in DB.dbQuartos )
            {
                if ( quarto.Key == num )
                {
                    return quarto.Value;
                }
            }
            return null;
        }

        public static bool TestaDisponibilidade(Quarto quarto)
        {
            return quarto.Disponivel;
        }

        public static bool ProcuraHospede(Hospede hospede)
        {
            foreach (Hospede h in DB.dbHospedes)
            {
                if (h.Nome.Equals(hospede.Nome))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
