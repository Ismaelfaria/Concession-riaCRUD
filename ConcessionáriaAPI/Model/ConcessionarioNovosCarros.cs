using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionáriaAPI.Model
{
    internal class ConcessionarioNovosCarros
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }
        public string chassi { get; set; }
        public int valor { get; set; }

        public ConcessionarioNovosCarros(int id, string nome, string cor, string chassi, int valor)
        {
            this.id = id;
            this.nome = nome;
            this.cor = cor;
            this.chassi = chassi;
            this.valor = valor;
        }

        public ConcessionarioNovosCarros(string nome, string cor, string chassi, int valor)
        {
            this.nome = nome;
            this.cor = cor;
            this.chassi = chassi;
            this.valor = valor;
        }
    }
}
