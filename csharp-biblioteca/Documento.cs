using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento{

        // PROPRIETA' E ATTRIBUTI

        public string CodeId {  get; set; }

        public string Titolo { get; set; }

        public uint Anno { get; set; }

        public string  Settore {  get; set; }

        public string Scaffale { get; set; }

        public string NomeAutore { get; set; }

        public string CognomeAutore { get; set; }


        public Documento(string CodeId, string Titolo, uint Anno, string Settore, string Scaffale, string NomeAutore, string CognomeAutore)
        { 
            this.CodeId = CodeId;
            this.Titolo = Titolo;
            this.Anno = Anno;
            this.Settore = Settore;
            this.Scaffale = Scaffale;
            this.NomeAutore = NomeAutore;
            this.CognomeAutore = CognomeAutore
           
        }

    }
}
