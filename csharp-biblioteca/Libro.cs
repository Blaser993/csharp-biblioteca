using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento{
        public uint Pagine { get; set; }

        public  Libro(uint Pagine, string CodeId, string Titolo, uint Anno, string Settore, string Scaffale, string NomeAutore, string CognomeAutore) : base(CodeId, Titolo, Anno, Settore, Scaffale, NomeAutore, CognomeAutore)
        { 
        this.Pagine = Pagine;
        }


        public override void LeggiDocumento()
        {
            Console.WriteLine($@"   
                - Titolo: {base.Titolo}
                - Anno: {base.Anno}
                - Settore: {base.Settore}
                - Scaffale: {base.Scaffale}
                - Autore: {base.NomeAutore} {base.CognomeAutore}
                - Pagine: {this.Pagine}
                
            ");

        }
    }


}
