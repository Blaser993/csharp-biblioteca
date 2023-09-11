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
        public DateTime Inizio { get; set; }

        public DateTime Fine { get; set; }

        public string Cognome { get; set; }

        public string Nome { get; set; }

        public Prestito(DateTime Inizio, DateTime Fine ,string Cognome, string Nome)
        {
            this.Inizio = Inizio;
            this.Fine = Fine;
            this.Cognome = Cognome;
            this.Nome = Nome;

        }
    }
}
