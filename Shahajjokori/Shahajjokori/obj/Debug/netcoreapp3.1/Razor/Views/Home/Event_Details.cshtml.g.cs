#pragma checksum "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c081cc2a376d153475cc74d89eb4a456ea51c219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Event_Details), @"mvc.1.0.view", @"/Views/Home/Event_Details.cshtml")]
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
#line 1 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\_ViewImports.cshtml"
using Shahajjokori;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\_ViewImports.cshtml"
using Shahajjokori.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c081cc2a376d153475cc74d89eb4a456ea51c219", @"/Views/Home/Event_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a33c8e4edb9634ea2c8d4523954a7c7aba6d12", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Event_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shahajjokori.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 320px; width: 800px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Donated", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<!--<h1>");
#nullable restore
#line 7 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
   Write(ViewBag.event_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->\n\n<div style=\"background-color: #fff5ee;\">\n    <div class=\"container\" style=\"padding-top: 5%;\">\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                <h3>");
#nullable restore
#line 13 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
               Write(Html.DisplayFor(model => model.e_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            </div>\n        </div>\n        <div class=\"row\" style=\"margin-top: 3%;\">\n            <div class=\"col-md-6\" style=\"margin-bottom:5%;\">\n                <p style=\"font-size:larger\">Created by: ");
#nullable restore
#line 18 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                   Write(ViewBag.org);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<button class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal1"" onclick=""Copy2();"" style=""font-size:19px; text-decoration: none; margin-bottom:0.5%; color:black;""><i class=""fas fa-info-circle""></i></button></p>
                <script type=""text/javascript"">
                    function Copy2() {
                        number.innerHTML='0'+");
#nullable restore
#line 21 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                        Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n                    }\n                </script>\n                <p style=\"font-size:larger; margin-top:-2%;\">Location: ");
#nullable restore
#line 25 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                  Write(Html.DisplayFor(model => model.e_location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 27 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Education</p>\n");
#nullable restore
#line 30 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Sponsoring</p>\n");
#nullable restore
#line 34 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Emergency Aid</p>\n");
#nullable restore
#line 38 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Medical Care</p>\n");
#nullable restore
#line 42 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Accidents</p>\n");
#nullable restore
#line 46 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                 if (ViewBag.event_cat == 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size:larger\">Category: Others</p>\n");
#nullable restore
#line 50 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                }    

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n                <p style=\"font-size:larger\">Opening: ");
#nullable restore
#line 52 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                Write(Html.DisplayFor(model => model.e_opening_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                <p style=\"font-size:larger\">Closing: ");
#nullable restore
#line 54 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                Write(Html.DisplayFor(model => model.e_closing_date));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 54 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                                                  Write(ViewBag.r_days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                <p style=\"font-size:large;\">Raised <span style=\"font-size:xx-large;\">");
#nullable restore
#line 56 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                                Write(ViewBag.raised_amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Tk. out of ");
#nullable restore
#line 56 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                                                                         Write(ViewBag.exp_amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <div class=\"progress\" style=\"margin-top: 5%; height:8px;\">\n");
#nullable restore
#line 58 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                       float raised = (float)ViewBag.raised_amount;
                                    float exp = (float)ViewBag.exp_amount;
                                    float percentage = (raised / exp) * 100;
                                    string perc = percentage + "%"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"progress-bar bg-info\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2913, "\"", 2951, 1);
#nullable restore
#line 62 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
WriteAttributeValue("", 2929, ViewBag.raised_amount, 2929, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\"");
            BeginWriteAttribute("aria-valuemax", " aria-valuemax=\"", 2970, "\"", 3005, 1);
#nullable restore
#line 62 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
WriteAttributeValue("", 2986, ViewBag.exp_amount, 2986, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 3006, "\"", 3038, 4);
            WriteAttributeValue("", 3014, "width:", 3014, 6, true);
#nullable restore
#line 62 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
WriteAttributeValue("", 3020, perc, 3020, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3025, ";", 3025, 1, true);
            WriteAttributeValue(" ", 3026, "height:8px;", 3027, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        \n                    </div>\n                </div>\n\n\n            </div>\n            <div class=\"col-md-6\">\n");
#nullable restore
#line 70 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                   string pic_name = ViewBag.event_pic;
                                string path = $"~/images/{pic_name}"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c081cc2a376d153475cc74d89eb4a456ea51c21915725", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                WriteLiteral(path);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 73 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                <p style=\"font-size:larger; margin-top: 3%;\">This event has received ");
#nullable restore
#line 75 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.e_donor_count));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" donations</p>
                <br />
                <button type=""button"" class=""btn btn-outline-info"" data-toggle=""modal"" data-target=""#exampleModal2"" style=""margin-right:5%;"">I want to Donate</button><button type=""button"" class=""btn btn-outline-info"" data-toggle=""modal"" data-target=""#exampleModal3"" onclick=""Copy();"">Share</button>
                <script type=""text/javascript"">
                    function Copy() {
                        urlCopied.innerHTML = window.location.href;

                    }
                </script>
                
            </div>
        </div>
        <div class=""row"" style=""margin-top: 5%; padding-bottom:5%;"">
            <div class=""col-md-12"">
                <h4>About the Event: </h4>
                <p style=""font-size:larger"">");
#nullable restore
#line 90 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                       Write(Html.DisplayFor(model => model.e_details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>

    </div>
</div>



<!-- Modal -->
<div class=""modal fade"" id=""exampleModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 104 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                          Write(ViewBag.org);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n            </div>\n            <div class=\"modal-body\">\n                <div>\n                    ");
#nullable restore
#line 109 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
               Write(ViewBag.org_about);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <textarea id=\"number\" style=\"width:-1%; height:-1px;\"></textarea>\n                </div>\n                <br />\n                <div>\n                    <p>Contact Number: ");
#nullable restore
#line 114 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                  Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""modal-footer"">
                <button onclick=""myFunction()"" style=""border: none; background-color: transparent;"">Copy Number</button>
                <script>
                    function myFunction() {
                        var copyText = document.getElementById(""number"");
                        copyText.select();
                        //copyText.setSelectionRange(0, 99999)
                        document.execCommand(""copy"");
                        alert(""Copied the number: "" + copyText.value);
                    }
                </script>
            </div>

        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 140 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                          Write(ViewBag.e_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            </div>\n            <div class=\"modal-body\" style=\"white-space:pre-line;\">\n                <p>Available accounts for transaction:</p>\n                <p>");
#nullable restore
#line 144 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
              Write(ViewBag.event_trans);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n\n            <div class=\"modal-footer\" style=\"text-align:center;\">\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c081cc2a376d153475cc74d89eb4a456ea51c21923011", async() => {
                WriteLiteral("I have donated");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                                                        WriteLiteral(ViewBag.event_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                <!--<input class=\"modal-footer\" id=\"myInput\" value=\"");
#nullable restore
#line 151 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                               Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" style=""border: none; background-color: transparent;"" readonly>-->
                <!--<button onclick=""myFunction()"" style=""border: none; background-color: transparent;"">Copy Number</button>-->
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 163 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                          Write(ViewBag.e_title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
            <div class=""modal-body"">
                <textarea id=""urlCopied"" style=""width:100%;""></textarea>
                <a href=""https://www.facebook.com/"" target=""_blank"" class=""fa fa-facebook"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #3B5998; color: white;""></a>
                <a href=""https://twitter.com"" target=""_blank"" class=""fa fa-twitter"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #55ACEE;color: white;""></a>
                <a href=""https://linkedin.com"" target=""_blank"" class=""fa fa-linkedin"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: center; text-decoration: none; margin: 5px 2px; background: #007bb5;color: white;""></a>
                <a href=""https://instagram.com"" target=""_blank"" class=""fa fa-instagram"" style=""padding: 10px 5px; font-size: 30px; width: 50px; text-align: cen");
            WriteLiteral(@"ter; text-decoration: none; margin: 5px 2px; background: #125688;color: white;""></a>
            </div>

            <div class=""modal-footer"" style=""text-align:center;"">

               
                    <button onclick=""myFunction2()"" style=""border: none; background-color: transparent;"">Copy link</button>
                    <script>
                        function myFunction2() {
                            var copyText = document.getElementById(""urlCopied"");
                            copyText.select();
                            copyText.setSelectionRange(0, 99999)
                            document.execCommand(""copy"");
                            //alert(""Copied the link: "" + copyText.value);
                        }
                    </script>
               

                <!--<input class=""modal-footer"" id=""myInput"" value=""");
#nullable restore
#line 188 "E:\3.2\SD - 5\Project-SD\Shajjokori-SD\Shahajjokori\Shahajjokori\Views\Home\Event_Details.cshtml"
                                                               Write(ViewBag.org_phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"border: none; background-color: transparent;\" readonly>-->\n                <!--<button onclick=\"myFunction()\" style=\"border: none; background-color: transparent;\">Copy Number</button>-->\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shahajjokori.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
