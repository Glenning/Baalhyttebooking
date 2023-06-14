using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Boernegruppe
    {
        public string ID;
        public string Navn;
        public string Aldersgruppe;
        public int AntalDeltagere;
        public enum AldersGruppe {pusling, tumling, pilt, væbner, seniorvæbner} //Opgave 12

        public override string ToString()
        {
            return ID + ", Navn: " + Navn + ", Aldersgruppe: " + Aldersgruppe + ", Deltagere: " + AntalDeltagere;
        }

        public Boernegruppe(string _id, string _navn, string _aldersgruppe, int _antaldeltagere) 
        {
            ID = _id;
            Navn = _navn;
            Aldersgruppe = _aldersgruppe;
            AntalDeltagere = _antaldeltagere;
        }

    }
}
