using System.Collections;
using System.Collections.Generic;
using Pousada.Entidades.Enum;


namespace Pousada.Entidades
{
    public abstract class Quarto
    {
        //IMPLEMENTAR DIAS USADOS AQUI OU NO STRATEGY??
        protected int tempoEstadia;
        protected int numeroQuarto;
        protected bool disponivel;
        protected double precoBase = 35;

        protected Quarto( int numero )
        {
           this.disponivel = true;
           this.numeroQuarto = numero; 
        }

        public int TempoEstadia { get => tempoEstadia; set => tempoEstadia = value; }
        public abstract int LimiteHospedes { get; }
        public abstract double PrecoDiaria { get; }
        
        public int NumeroQuarto { get => numeroQuarto; }
        
        public abstract TipoEnum TipoQuarto { get; }

        public bool Disponivel { get => this.disponivel; }

        public string Descricao { get => this.GeraDescricao(); }
        public abstract List<Hospede> Hospedes { get; }
       

        protected string GeraDescricao()
        {
            // TIRAR DAQUI ?
            string descricao =  string.Format($"\n --- QUARTO {this.numeroQuarto} --- ");
            descricao += string.Format($"\nTipo do quarto: {this.TipoQuarto}");
            descricao += string.Format($"\nPreco da diaria: {this.PrecoDiaria}");
            //descricao += string.Format($"\nNumero do quarto: {this.numeroQuarto}");
            descricao += string.Format($"\nDisponivel: {this.Disponivel}");
            descricao += string.Format($"\nHospedes: ");
            descricao += "\n";
            foreach (Hospede h in Hospedes)
            {
                descricao += string.Format($"{h.Nome} ");
            }
            return descricao;
        }
        public void Ocupar()
        {
            this.disponivel = false;
        }
        public void Desocupar()
        {
            this.Hospedes.Clear();
            this.TempoEstadia = 0;
            this.disponivel = true;
        }

        public abstract double CalculaPreco();

    }
}
