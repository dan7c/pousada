using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;

namespace Pousada.QFactories
{
    class QSimplesFactory : QFactory
    {
        public QSimplesFactory()
        {
        }

        public override Quarto GetQuarto(int numeroQuarto)
        {
            return new QuartoSimples(numeroQuarto);
        }
    }
}
