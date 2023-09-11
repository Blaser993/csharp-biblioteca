using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string Cognome { get; set; } 

        public string Nome { get; set; }    

        public string Email {  get; set; }

        public string Psw {  get;  set; }

        public uint Telefono { get; set; }


        public Utente(string Cognome, string Nome, string Email, string Psw, uint Tel) 
        { 
            this.Cognome = Cognome;
            this.Nome = Nome;
            this.Email = Email;
            this.Psw = Psw;
            this.Telefono = Tel;
        }
    }
}
