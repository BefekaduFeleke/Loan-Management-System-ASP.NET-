using LoanManagementDone.Areas.Identity.Data;
using LoanManagementDone.Models;
using LoanManagementDone.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LoanManagementDone.Controllers
{

    public class CustomerController : Controller
    {


        LoanManagementSystemlContext _context = new LoanManagementSystemlContext();

        private readonly UserManager<ApplicationUser> _userManager;
        public CustomerController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public class Random_Number
        {
            private int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoanCreate()
        {
            LoanManagementSystemlContext model = new LoanManagementSystemlContext();
            return View();
        }
        [HttpPost]
        public ActionResult LoanCreate(LoanApplication Loan)

        {

            if (!ModelState.IsValid)
                return View(Loan);

            _context.LoanApplications.Add(Loan);

            _context.SaveChanges();
            return RedirectToAction("MyLoanstwo");
        }



        public ActionResult MyLoanstwo()
        {
           var sub =_userManager.GetUserId(HttpContext.User);
            int subb = Int16.Parse(sub);
            var custi = _context.Customers.Find(subb).CustomerId;
            List<LoanApplication> loanApplications = _context.LoanApplications.Where(x => x.CustomerId==custi).ToList();
            List<LoanType> loanTypes = _context.LoanTypes.ToList();

            var multipletableapptype = from app in loanApplications
                                       join typee in loanTypes on app.LoanTypeId equals typee.LoanTypeId into table1
                                       from typee in table1.DefaultIfEmpty()
                                       select new MultipleClassApplication { LoanApplicationsmultipleapp = app, LoanTypesmultipleapp = typee };


            return View(multipletableapptype);



        }

        public ActionResult OngoingLoans()
        {
            var sub = _userManager.GetUserId(HttpContext.User);
            int subb = Int16.Parse(sub);
            var acc = "Approved";
            var custi = _context.Customers.Find(subb).CustomerId;
            List<LoanApplication> loanApplications = _context.LoanApplications.Where(x => x.CustomerId == custi).Where(x=>x.LoanStatus==acc).ToList();
            List<LoanType> loanTypes = _context.LoanTypes.ToList();

            var multipletableapptype = from app in loanApplications
                                       join typee in loanTypes on app.LoanTypeId equals typee.LoanTypeId into table1
                                       from typee in table1.DefaultIfEmpty()
                                       select new MultipleClassApplication { LoanApplicationsmultipleapp = app, LoanTypesmultipleapp = typee };


            return View(multipletableapptype);



        }




        public ActionResult LoanAppDelete(int? id)
        {

            var exsitingloanapp = _context.LoanApplications.Find(id);
            return View(exsitingloanapp);
        }
        [HttpPost]
        public ActionResult LoanAppDelete(int? id, LoanApplication loanApplication)
        {
            var exsitingLOAN = _context.LoanApplications.Find(id);
            _context.LoanApplications.Remove(exsitingLOAN);
            _context.SaveChanges();
            return RedirectToAction("MyLoanstwo");
        }
        public ActionResult LoanAppDetails(int? id)
        {

            var detailsLoanApp = _context.LoanApplications.Find(id);

            return View(detailsLoanApp);
        }
       


        }
}






