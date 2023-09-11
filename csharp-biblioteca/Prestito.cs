using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public string Inizio { get; set; }

        public string Fine { get; set; }

        public string Cognome { get; set; }

        public string Nome { get; set; }

        public Prestito(string Inizio, string Fine ,string Cognome, string Nome)
        {
            this.Inizio = Inizio;
            this.Fine = Fine;
            this.Cognome = Cognome;
            this.Nome = Nome;

        }
    }
}
