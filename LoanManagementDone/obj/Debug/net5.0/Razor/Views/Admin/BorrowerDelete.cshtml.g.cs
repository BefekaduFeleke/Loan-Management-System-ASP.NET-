#pragma checksum "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84e01d1b01c60044c029874df09ff209390279f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BorrowerDelete), @"mvc.1.0.view", @"/Views/Admin/BorrowerDelete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84e01d1b01c60044c029874df09ff209390279f3", @"/Views/Admin/BorrowerDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_BorrowerDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementDone.Models.MultipleAdminView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
  
    ViewBag.Title = "HandleLoanApplications";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<h3>Are you sure you want to delete this Borrower\'s Data</h3>\r\n<table class=\"table table-hover\">\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
      
        var loanappid = Model.LoanApplicationAdminView.LoanApplicationId;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <tr>\r\n        <th>Customer ID</th>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.CustomerAdminview.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Customer Name</th>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
        Write(Model.CustomerAdminview.FirstName + " " + Model.CustomerAdminview.MiddleName + " " + Model.CustomerAdminview.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Customer Phone Number 1</th>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.CustomerAdminview.PhoneNumberOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Customer Phone Number 2</th>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.CustomerAdminview.PhoneNumberTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Total To Be Paid</th>\r\n        <td>");
#nullable restore
#line 43 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.LoanApplicationAdminView.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Loan Type</th>\r\n        <td>");
#nullable restore
#line 47 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.LoanTypesAdminView.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Loan Approval Date</th>\r\n        <td>");
#nullable restore
#line 52 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.LoanApplicationAdminView.LoanApplicationApprovedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Payment Date</th>\r\n        <td>");
#nullable restore
#line 56 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.LoanApplicationAdminView.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <th>Payment Status</th>\r\n        <td>");
#nullable restore
#line 62 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
       Write(Model.LoanApplicationAdminView.PaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n<span>\r\n");
#nullable restore
#line 68 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
     using (Html.BeginForm("BorrowerDelete", "Admin", new { id = Model.LoanApplicationAdminView.LoanApplicationId }, FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
   Write(Html.HiddenFor(m => m.LoanApplicationAdminView.LoanApplicationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-primary\" value=\"Delete\" />\r\n");
#nullable restore
#line 73 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDelete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Admin/LoanApplications\" class=\"btn btn-info\">Back to home Page</a>\r\n</span>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementDone.Models.MultipleAdminView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
