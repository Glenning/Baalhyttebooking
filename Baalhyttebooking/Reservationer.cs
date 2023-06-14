using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
        public int ID;
        Dictionary<int, Reservation> _reservations;
        //RegistrerReservation(Reservation reservation);

        public Reservationer(int ID, Dictionary<int, Reservation> _reservations)
        {

        }
        public void PrintReservationer () 
        {
            foreach (var Reservation  in _reservations) 
            { Console.WriteLine(Reservation); }
        }
    }
}
