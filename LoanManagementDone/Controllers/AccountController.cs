using BootstrapTemplateIntegration.Controllers;
using LoanManagementDone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace loanmanagementdone.controllers
{
    public class accountcontroller :Controller

    {
        LoanManagementSystemlContext _context = new LoanManagementSystemlContext();
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }
        public ActionResult verify(AdminController add, Customer cust)
        {
            return View();
        }
    }
}
