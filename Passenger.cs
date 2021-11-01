using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    enum Ticket {FirstClass, SecondClass, Economy, Stowaways}
    internal class Passenger : Person
    {
        public Ticket Ticket { get; set; }
        public int Cabin { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public void ChangeTicket(Ticket newTicket)
        {
            if (Ticket == newTicket)
            {
                Console.WriteLine("Det er altså den samme type billlet. Tsk tsk");
                return;
            }

            if (newTicket == Ticket.Stowaways)
            {
                Console.WriteLine("Vi degraderer ikke til stowaway");
                return;
            }

            Ticket = newTicket;
        }

    }
}
