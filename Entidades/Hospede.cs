using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pousada.Consumiveis;


namespace Pousada.Entidades
{
    public class Hospede
    {
        private string _nome;
        private string _endereco;
        private List<IOpcionais> _opcionais;
        public Quarto _quarto;

        //public List<IOpcionais> Opcionais { get => _opcionais; }
        public string Nome { get => _nome; }
        public string Endereco { get => _endereco; }
        public Hospede(string nome, string endereco)
        {
            this._nome = nome;
            this._endereco = endereco;
            _opcionais = new List<IOpcionais>();
        }

        public Quarto Quarto { get => _quarto; set => _quarto = value; }
        public List<IOpcionais> Opcionais { get => _opcionais; }
        public void AddAlimentacao()
        {
            IOpcionais alimentacao = new Alimentacao();
            _opcionais.Add(alimentacao);
        }
        public void AddTelefone()
        {
            IOpcionais telefone = new Telefone();
            _opcionais.Add(telefone);
        }
        public double PrecoOpcionais()
        {
            double preco = 0;
            foreach(IOpcionais opc in this._opcionais)
            {
                preco += opc.PrecoDiario;
            }
            return preco;
        }

    }
}
