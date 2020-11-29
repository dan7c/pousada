using System.Collections.Generic;
using Pousada.Entidades.Enum;

namespace Pousada.Entidades
{
    public class QuartoDuplo : Quarto
    {
        private TipoEnum _tipoQuarto;
        private int _limiteHospedes;
        private double _multiplicador;
        private double _precoDiaria;
       private List<Hospede> _hospedes;

        public QuartoDuplo(int numero) : base(numero)
        {
            this._tipoQuarto = TipoEnum.DUPLO;
            this._limiteHospedes = 2;
            this._multiplicador = 1.85;
            this._precoDiaria = CalculaPreco();
            _hospedes = new List<Hospede>();
        }


        public override TipoEnum TipoQuarto => _tipoQuarto;
        public override int LimiteHospedes => _limiteHospedes;
        public override double PrecoDiaria => this.CalculaPreco();

        public override List<Hospede> Hospedes => _hospedes;

        public override double CalculaPreco()
        {
            return precoBase * _multiplicador;
        }
    }
}