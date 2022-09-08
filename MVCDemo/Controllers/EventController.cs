using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventController : Controller
    {

        public List<Booking> events { get; set; }
        
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add (new Booking { Title = "ask Ceo", Date = DateTime.Today, Quantity = 20 });
            events.Add  (new Booking { Title = "Alan walker", Date = DateTime.Today, Quantity = 30 });
            
            return View(events);
        }
    }
}
