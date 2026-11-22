using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC2.Contexts;
using MVC2.Entities;

namespace MVC2.Controllers
{
    public class PlansController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using GymDbContext context = new GymDbContext();
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
