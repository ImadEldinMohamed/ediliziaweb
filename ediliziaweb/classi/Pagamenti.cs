using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ediliziaweb.classi
{
    public class Pagamenti
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Importo{ get; set; }
        public bool Stipendio { get; set; }

        public int IDdipendente { get; set; }

        public Pagamenti() { }
        public Pagamenti(DateTime data,double Importo,bool stipendio,int IDdipendente )
        { 
            this.Data = data;
         this.Importo = Importo;
            this.Stipendio = stipendio;
            this.IDdipendente = IDdipendente;
        }
    }
}