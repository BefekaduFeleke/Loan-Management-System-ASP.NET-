using LoanManagementDone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using LoanManagementDone.Areas.Identity.Data;

namespace BootstrapTemplateIntegration.Controllers
{
    public class AdminController : Controller
    {
        public string insertmessage;
        LoanManagementSystemlContext _context = new LoanManagementSystemlContext();
        // GET: Admin

        private readonly UserManager<ApplicationUser> _userManager;
        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            return View(customer);
            
        }

        public ActionResult Details(int? id)
        {

            var customers = _context.Customers.FirstOrDefault(x => x.CustomerId == id);



            var surid = _context.Customers.Find(id).SuretyId;
            var suro = _context.Sureties.Find(surid);

            var mult = new MultipleCustSuretyView
            {
                Custmult = customers,
                Suretymult = suro

            };
           

            return View(mult);
        }

        public ActionResult LOanAppDetails(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }





        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer custmr)

        {
            if (!ModelState.IsValid)
                return View(custmr);
            _context.Customers.Add(custmr);
            _context.SaveChanges();
            insertmessage = "New User Record Inserted Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult SuretyCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SuretyCreate(Surety surety)

        {
            if (!ModelState.IsValid)
                return View(surety);
            _context.Sureties.Add(surety);
            _context.SaveChanges();
            ViewBag.Suretyidd = surety.SuretyId;
            return RedirectToAction("Create");
        }

        public ActionResult Edit(int? id)
        {
            var exsitingCust = _context.Customers.Find(id);
            return View(exsitingCust);
        }



        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





        public ActionResult Delete(int? id)
        {
            var exsitingCust = _context.Customers.Find(id);
            return View(exsitingCust);
        }
        [HttpPost]
        public ActionResult Delete(int? id, Customer customer)
        {
            var exsitingCust = _context.Customers.Find(id);
            _context.Customers.Remove(exsitingCust);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult LoanApplications()
        {



            List<LoanApplication> loanApplications = _context.LoanApplications.ToList();
            List<LoanType> loanTypes = _context.LoanTypes.ToList();
            List<Customer> customers = _context.Customers.ToList();

            var multipleAdminVieww = from app in loanApplications
                                     join custt in customers on app.CustomerId equals custt.CustomerId into table1
                                     from custt in table1.DefaultIfEmpty()
                                     join typee in loanTypes on app.LoanTypeId equals typee.LoanTypeId into table2
                                     from typee in table2.DefaultIfEmpty()

                                     select new MultipleAdminView { LoanApplicationAdminView = app, CustomerAdminview = custt, LoanTypesAdminView = typee };




            return View(multipleAdminVieww);






        }







        public ActionResult HandleLoanApplications(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }
        [HttpPost]
        public ActionResult ApproveApplications(MultipleAdminView multiple, int? id)
        {




            var approver = _context.LoanApplications.Find(id);

            approver.LoanStatus = "Approved";
            approver.LoanApplicationApprovedDate = DateTime.Now;
            if (approver.LoanTypeId == 2) { approver.PaymentDate = DateTime.Now.AddDays(30); }
            else if (approver.LoanTypeId == 3)
            { approver.PaymentDate = DateTime.Now.AddDays(90); }
            else if (approver.LoanTypeId == 4)
            { approver.PaymentDate = DateTime.Now.AddDays(180); }

            approver.PaymentStatus = "Not Paid";
            _context.SaveChanges();

            return RedirectToAction("BorrowerList");
        }
        [Authorize(Policy = "rolecreation")]
        public ActionResult BorrowerList()
        {

            var sub = "Approved";

            List<LoanApplication> loanApplications = _context.LoanApplications.Where(x => x.LoanStatus == sub).ToList();
            List<LoanType> loanTypes = _context.LoanTypes.ToList();
            List<Customer> customers = _context.Customers.ToList();

            var multipleAdminVieww = from app in loanApplications
                                     join custt in customers on app.CustomerId equals custt.CustomerId into table1
                                     from custt in table1.DefaultIfEmpty()
                                     join typee in loanTypes on app.LoanTypeId equals typee.LoanTypeId into table2
                                     from typee in table2.DefaultIfEmpty()

                                     select new MultipleAdminView { LoanApplicationAdminView = app, CustomerAdminview = custt, LoanTypesAdminView = typee };




            return View(multipleAdminVieww);






        }





        public ActionResult LOanAppDelete(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }
        [HttpPost]
        public ActionResult DeleteLoanApp(MultipleAdminView multiple, int? id)
        {



            var delete = _context.LoanApplications.Find(id);

            _context.LoanApplications.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("LoanApplications");
        }



        public ActionResult BorrowerDelete(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }
        [HttpPost]
        public ActionResult BorrowerDelete(MultipleAdminView multiple, int? id)
        {



            var delete = _context.LoanApplications.Find(id);
            if (delete.PaymentStatus == "Not Paid")
            {
                return RedirectToAction("BorrowerList");
            }

            _context.LoanApplications.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("BorrowerList");
        }


        public ActionResult BorrowerDetails(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }



        public ActionResult HandlePayment(int? id)
        {
            var loanApplications = _context.LoanApplications.FirstOrDefault(x => x.LoanApplicationId == id);

            var custid = _context.LoanApplications.Find(id).CustomerId;
            var custo = _context.Customers.Find(custid);

            var ltid = _context.LoanApplications.Find(id).LoanTypeId;
            var lt = _context.LoanTypes.Find(ltid);

            var mult = new MultipleAdminView
            {
                LoanApplicationAdminView = loanApplications,
                CustomerAdminview = custo,
                LoanTypesAdminView = lt
            };

            return View(mult);
        }
        [HttpPost]
        public ActionResult ApprovePayment(MultipleAdminView multiple, int? id)
        {




            var approver = _context.LoanApplications.Find(id);

            approver.PaymentStatus = "Paid";
            //It can be deleted kezi behuala but we haven't
            _context.SaveChanges();

            return RedirectToAction("BorrowerList");
        }

        [HttpPost]
        public ActionResult ReportCustomer(MultipleAdminView multiple, int? id)
        {

            var reporter = _context.LoanApplications.Find(id);
            var custid = reporter.CustomerId;

            var Badcustomer = _context.Customers.Find(custid);

            Badcustomer.Rating -= 1;
            Badcustomer.CustomerStatus = "Bad";

            reporter.PaymentStatus = "Reported";


            _context.SaveChanges();

            return RedirectToAction("BadCustomerList");
        }

        [Authorize(Policy = "rolecreation")]
        public ActionResult BadCustomerList()
        {



            var st = "Reported";
            List<Customer> customers = _context.Customers.ToList();
            List<LoanType> loanTypes = _context.LoanTypes.ToList();
            List<LoanApplication> loanApplications = _context.LoanApplications.Where(x => x.PaymentStatus == st).ToList();

            var multipleAdminVieww = from app in loanApplications
                                     join custt in customers on app.CustomerId equals custt.CustomerId into table1
                                     from custt in table1.DefaultIfEmpty()
                                     join typee in loanTypes on app.LoanTypeId equals typee.LoanTypeId into table2
                                     from typee in table2.DefaultIfEmpty()

                                     select new MultipleAdminView { LoanApplicationAdminView = app, CustomerAdminview = custt, LoanTypesAdminView = typee };




            return View(multipleAdminVieww);






        }

      


    }
}
