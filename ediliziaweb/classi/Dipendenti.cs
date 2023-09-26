using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ediliziaweb.classi
{
    public class Dipendenti
    {

        public int IDdipendente;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Cf { get; set; }
        public bool Sposato { get; set; }
        public int Figli{ get; set; }
        public string Mansione { get; set; }


        public Dipendenti() { }
        public Dipendenti(string Nome, string Cognome, string Indirizzo, string Cf, bool Sposato, int Figli, string Mansione)
        {
               this.Nome = Nome;
               this.Cognome = Cognome;
            this.Indirizzo = Indirizzo;
            this.Cf = Cf;
            this.Sposato = Sposato;
            this.Figli = Figli;
            this.Mansione = Mansione;
            
        }

    }

    
}