using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pousada.Consumiveis
{
    class Alimentacao : IOpcionais
    {
        private readonly string _titulo;
        private readonly double _precoDiario;

        public Alimentacao()
        {
            this._precoDiario = 20.00;
            this._titulo = "ALIMENTACAO";
        }

        public double PrecoDiario => _precoDiario;

        public string Titulo => _titulo;
    }
}
