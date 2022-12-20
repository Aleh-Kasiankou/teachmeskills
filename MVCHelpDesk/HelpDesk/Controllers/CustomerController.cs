using HelpDesk.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HelpDeskDbContext _dbContext;
        public CustomerController(HelpDeskDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET
        public IActionResult Index()
        {
            return View(_dbContext.SupportRequests);
        }
    }
}