using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.QFactories;
using Pousada.Entidades;

namespace Pousada.BancoDados
{

    /* CLASSE APENAS PARA SIMULAÇÃO DE UM BANCO DE DADOS */
    public class DB
    {
        public static Dictionary<int, Quarto> dbQuartos;
        public static List<Hospede> dbHospedes;
        private QFactory factory;

        public DB()
        {
            dbQuartos = new Dictionary<int, Quarto>();
            dbHospedes = new List<Hospede>();
            PreencherDbQuartos();
        }


        /* MÉTODO APENAS PARA SIMULAÇÃO DE PREENCHIMENTO DO DATABASE */
        private void PreencherDbQuartos()
        {
            for (int index = 1; index <= 9; index++)
            {
                if ( index <= 3 )
                {
                    factory = new QSimplesFactory();
                    Quarto qSimples = factory.GetQuarto(index);
                    dbQuartos.Add(index, qSimples);
                } 
                else if ( index > 3 && index <= 6)
                {
                    factory = new QDuploFactory();
                    Quarto qDuplo = factory.GetQuarto(index);
                    dbQuartos.Add(index, qDuplo);
                } 
                else if (index > 6)
                {
                    factory = new QTriploFactory();
                    Quarto qTriplo = factory.GetQuarto(index);
                    dbQuartos.Add(index, qTriplo);
                }
            }
        }
    }
}
