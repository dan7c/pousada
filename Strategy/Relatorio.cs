using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Entidades;

namespace Pousada.Strategy
{
    public class Relatorio : IStrategy
    {
        public void Procedimento(Quarto quarto)
        {
            System.Console.WriteLine(quarto.Descricao);
        }
    }
}
