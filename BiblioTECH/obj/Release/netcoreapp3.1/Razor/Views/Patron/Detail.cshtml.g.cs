#pragma checksum "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81eb46c111871f2369e6d3d8d8051744bffca7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
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
#line 1 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\_ViewImports.cshtml"
using BiblioTECH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\_ViewImports.cshtml"
using BiblioTECH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
using BiblioTECH.Models.Patron;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81eb46c111871f2369e6d3d8d8051744bffca7e", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103ea2ea11cadad1713edb5e249cd31f73015e0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BiblioTECH.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container container-margin-adjustment\">\r\n    <div class=\"jumbotron\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <div>\r\n                    <h2>");
#nullable restore
#line 14 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronEmail\">Email: ");
#nullable restore
#line 16 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Library Card ID: ");
#nullable restore
#line 17 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
#nullable restore
#line 18 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
#nullable restore
#line 19 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
#nullable restore
#line 20 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
#nullable restore
#line 21 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibrary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
#nullable restore
#line 24 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 25 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
#nullable restore
#line 29 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
#nullable restore
#line 36 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
#nullable restore
#line 40 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 43 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Library Asset ID: ");
#nullable restore
#line 43 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
#nullable restore
#line 46 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
#nullable restore
#line 49 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 53 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 56 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
#nullable restore
#line 60 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
#nullable restore
#line 66 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
#nullable restore
#line 70 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 72 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Placed ");
#nullable restore
#line 72 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 73 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 76 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
#nullable restore
#line 80 "D:\Anul 4-IS-semestrul 2\Licenta\Aplicatie_fara_sistem_auth\BiblioTECH\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BiblioTECH.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591