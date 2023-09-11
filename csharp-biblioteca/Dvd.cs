using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Documento{
        public float Durata { get; set; }

        public Dvd(float Durata, string CodeId, string Titolo, uint Anno, string Settore, string Scaffale, string NomeAutore, string CognomeAutore) : base(CodeId, Titolo, Anno, Settore, Scaffale, NomeAutore, CognomeAutore)
        {
            this.Durata = Durata;
        }
    }

    //public override void LeggiDvd()
    //{
    //    Console.WriteLine()
    //}
}
