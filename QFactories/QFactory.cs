using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;

namespace Pousada.QFactories
{
    public abstract class QFactory
    {
        public abstract Quarto GetQuarto(int numero);
    }
}
