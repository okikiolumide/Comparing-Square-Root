#pragma checksum "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e940e83c82b16968d1266a6ee4f334f7214813dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sqr_sqr), @"mvc.1.0.view", @"/Views/Sqr/sqr.cshtml")]
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
#line 1 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\_ViewImports.cshtml"
using squareRoot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\_ViewImports.cshtml"
using squareRoot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e940e83c82b16968d1266a6ee4f334f7214813dd", @"/Views/Sqr/sqr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fda7fe3593d859b2703f173ad6b3c722340fdfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Sqr_sqr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sqr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "sqr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> Square Root Calculator</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
  
   if(ViewBag.Result1 > ViewBag.Result2 )
   {//Displays result has a higher square root to the user. 

#line default
#line hidden
#nullable disable
            WriteLiteral("       <p>The number ");
#nullable restore
#line 12 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                Write(ViewBag.firstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square root ");
#nullable restore
#line 12 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                      Write(ViewBag.Result1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 12 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                                                                                Write(ViewBag.secondNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 12 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                                                                                                                       Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
   } 
   else if (ViewBag.Result1 < ViewBag.Result2)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <p>The number ");
#nullable restore
#line 16 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                Write(ViewBag.secondNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square root ");
#nullable restore
#line 16 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                       Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 16 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                                                                                 Write(ViewBag.firstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 16 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                                                                                                                                                       Write(ViewBag.Result1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
   }
   else if (ViewBag.Result1 == ViewBag.Result2)
   {// Displays Result if both inputted values are the same

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The numbers inputted (");
#nullable restore
#line 20 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
                            Write(ViewBag.firstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(") have the same square root. Try Again!!!</p>\r\n");
#nullable restore
#line 21 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
   }
   else
   {// Displays if inputted values are negative numbers

#line default
#line hidden
#nullable disable
            WriteLiteral("       <p>Invalid Entry!!! Try Again</p>\r\n");
#nullable restore
#line 25 "C:\Users\OLUMIDE\Desktop\HNG C#\squareRoot\Views\Sqr\sqr.cshtml"
   }


#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e940e83c82b16968d1266a6ee4f334f7214813dd8512", async() => {
                WriteLiteral(@"
       <div class=""form-group"">
        <label> First Number</label>
        <input class=""form-control-sm"" type=""number"" placeholder=""First Number"" name=""firstNumber"" required/>
       </div> 
        
        <div class=""form-group"">
        <label> Second Number</label>
        <input class=""form-control-sm"" type=""number"" placeholder=""Second Number"" name =""secondNumber"" required/>
       </div> 
        
        
        
        <button type=""submit"" class=""btn btn-primary"">Calculate</button>
        

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
