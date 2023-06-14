using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        public int ID;
        public DateTime Tidspunkt;
        Boernegruppe Boernegruppe;
        public override string ToString()
        {
            return "Dit reservationsID: " + ID + ", Gruppe: " + Tidspunkt + ", " + Boernegruppe;
        }
        public Reservation(int _id, DateTime _tidspunkt, Boernegruppe _boernegruppe)
        {
            ID = _id;
            Tidspunkt = _tidspunkt;
            Boernegruppe = _boernegruppe;
        }
    }
}
