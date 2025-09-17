using Microsoft.AspNetCore.Mvc;
using CMCSystem.Models;
using System.Collections.Generic;

namespace CMCSystem.Controllers
{
    public class ClaimController : Controller
    {
        // Pretend database – preloaded claims
        private static List<Claim> claims = new List<Claim>
        {
            new Claim { Id = 1, PassengerName = "John Doe", ClaimType = "Lost Baggage", Description = "Suitcase missing from flight SA203", Status = "Pending" },
            new Claim { Id = 2, PassengerName = "Jane Smith", ClaimType = "Flight Delay", Description = "Claiming compensation for 6-hour delay", Status = "Approved" },
            new Claim { Id = 3, PassengerName = "Ali Khan", ClaimType = "Damaged Item", Description = "Laptop screen cracked in checked baggage", Status = "Rejected" }
        };

        // Show all claims
        public IActionResult Index()
        {
            return View(claims);
        }

        // GET: Claim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claim/Create (Dummy Submission)
        [HttpPost]
        public IActionResult Create(Claim newClaim)
        {
            // Pretend to "save" claim
            newClaim.Id = claims.Count + 1;
            newClaim.Status = "Submitted";
            claims.Add(newClaim);

            return RedirectToAction("Index");
        }
    }
}
