using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ThaiMovie.Models;
using ThaiMovie.ViewModels;

namespace ThaiMovie.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(n => n.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            var customers = _context.Customers.Include(n => n.MembershipType).SingleOrDefault(n => n.Id == id);
            if (customers == null)
                return HttpNotFound();
            return View(customers);
        }
    }
}