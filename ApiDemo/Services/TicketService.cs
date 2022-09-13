using ApiDemo.Models;
using System.Security.Cryptography.X509Certificates;

namespace ApiDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get;}

        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    
                    new Ticket { Id=1, BookedFor="Platinum Plus",Price=5000,Qty=200000 },
                    new Ticket { Id=11,BookedFor="Platinum ",Price=4000,Qty=300000 },
                    new Ticket{Id=12,BookedFor="Gold",Price=3000,Qty=500000},
                    new Ticket{Id = 14, BookedFor="Silver",Price=2000,Qty=500000},
                    new Ticket{Id = 15, BookedFor="General",Price=5000,Qty=1000000}
                };

       
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x=> x.Id == id);
            return ticket;
        }
    }
}
