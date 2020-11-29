using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pousada.Entidades.Enum;

namespace Pousada.Entidades
{
    public class QuartoSimples : Quarto
    {

        private TipoEnum _tipoQuarto;
        private int _limiteHospedes;
        private double _multiplicador;
        private double _precoDiaria;
        private List<Hospede> _hospedes;

        public QuartoSimples(int numero) : base(numero)
        {
            this._tipoQuarto = TipoEnum.SIMPLES;
            this._limiteHospedes = 1;
            this._multiplicador = 1;
            this._precoDiaria = CalculaPreco();
            _hospedes = new List<Hospede>();
        }

        public override TipoEnum TipoQuarto => _tipoQuarto;
        public override int LimiteHospedes => _limiteHospedes;
        public override double PrecoDiaria => _precoDiaria;

        public override List<Hospede> Hospedes => _hospedes;

      //  public override double multiplicador => _multiplicador;
        
        public override double CalculaPreco()
        {
            return precoBase * _multiplicador;
        }
    }
}

       // public override int numeroQuarto { get => this._numeroQuarto; }

        //public override bool disponivel => _disponivel;

        //public override string descricao => this.Descricao();

        // public override string Descricao()
        // {
        //     return "Quarto simples descriçao!";
        // }
