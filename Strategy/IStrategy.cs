using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;

namespace Pousada.Strategy
{
    public interface IStrategy
    {
        public void Procedimento(Quarto quarto);

    }
}
