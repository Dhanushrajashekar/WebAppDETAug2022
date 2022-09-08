using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;


namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public List<Friends> friends { get; set; }

        public IActionResult Index()
        {
            friends = new List<Friends>();
            friends.Add(new Friends { FriendID = 1 , FriendName="Dhanush", place="Bangalore"});
            friends.Add(new Friends { FriendID = 2, FriendName = "Rohan", place = "Bangalore" });
            return View(friends);
        }
    }
}
