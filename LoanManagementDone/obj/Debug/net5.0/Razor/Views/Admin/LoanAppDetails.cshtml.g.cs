#pragma checksum "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2559d0045f2be55f79554a7d3d611c33741556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LoanAppDetails), @"mvc.1.0.view", @"/Views/Admin/LoanAppDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2559d0045f2be55f79554a7d3d611c33741556", @"/Views/Admin/LoanAppDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_LoanAppDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementDone.Models.LoanApplication>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
  
    ViewBag.Title = "Loan Application Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Loan Application Details</h2>\r\n\r\n\r\n<table class=\"table table-hover\">\r\n");
            WriteLiteral("    <tr>\r\n        <th>Loan Control Number </th>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.LoanControlNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Loan Amount</th>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.LoanAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Purpose</th>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.Purpose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>LoanApplicationSubmissionDate</th>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.LoanApplicationSubmissionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>LoanApplicationApprovedDate</th>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.LoanApplicationApprovedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>LoanStatus</th>\r\n        <td>");
#nullable restore
#line 40 "C:\Users\befek\OneDrive\Desktop\School Files\Summer\WebII\YYYYLoanManagementDone\LoanManagementDone\LoanManagementDone\Views\Admin\LoanAppDetails.cshtml"
       Write(Model.LoanStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n<a href=\"/Admin/Index\" class=\"btn btn-info\">Back to home Page</a>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementDone.Models.LoanApplication> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
