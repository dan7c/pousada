using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;


namespace Pousada.QFactories
{
    class QTriploFactory : QFactory
    {
        public QTriploFactory()
        {
        }

        public override Quarto GetQuarto(int numeroQuarto)
        {
            return new QuartoTriplo(numeroQuarto);
        }
    }
}
