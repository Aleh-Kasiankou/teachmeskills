using HelpDesk.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Controllers
{
    public class SupportController : Controller
    {
        private readonly HelpDeskDbContext _dbContext;

        public SupportController(HelpDeskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET
        public IActionResult Index()
        {
            return View(_dbContext.SupportRequests
                .Include(x => x.SupportDepartment)
                .Include(x => x.SupportSpecialist));
        }
    }
}