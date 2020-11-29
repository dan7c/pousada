using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pousada.Consumiveis
{
    class Telefone : IOpcionais
    {
        private readonly string _titulo;
        private readonly double _precoDiario;

        public Telefone()
        {
            this._precoDiario = 9.80;
            this._titulo = "TELEFONE";
        }

        public double PrecoDiario => _precoDiario;

        public string Titulo => _titulo;
    }
}
