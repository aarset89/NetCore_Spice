#pragma checksum "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7659e6a6fae800c272b4614837510f9c49a64d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categories/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categories_Details))]
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
#line 1 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7659e6a6fae800c272b4614837510f9c49a64d3c", @"/Areas/Admin/Views/Categories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 8 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
 using (Html.BeginForm("Save", "Categories"))
{
    

#line default
#line hidden
            BeginContext(134, 24, false);
#line 10 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(196, 38, true);
            WriteLiteral("    <div class=\"container bg-light\">\r\n");
            EndContext();
            BeginContext(274, 75, true);
            WriteLiteral("        <h2>category</h2>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(350, 26, false);
#line 17 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
       Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(376, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(391, 83, false);
#line 18 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
       Write(Html.TextBoxFor(m => m.Name, "", new { @class = "form-control", @disabled="true" }));

#line default
#line hidden
            EndContext();
            BeginContext(474, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(489, 74, false);
#line 19 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(563, 107, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row form-group\">\r\n            <div class=\"col-6\">\r\n\r\n                ");
            EndContext();
            BeginContext(671, 23, false);
#line 24 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(694, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(909, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(926, 117, false);
#line 27 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.ActionLink("Go to Edit","Edit","Categories",new { id = Model.Id }, new{ @class="btn btn-success form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 82, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-6 text-right\">\r\n                ");
            EndContext();
            BeginContext(1126, 106, false);
#line 30 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.ActionLink("Back to list", "index", "Categories", null, new { @class = "btn btn-info form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 52, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 35 "E:\Clouds\Dropbox\Estudio_visual_studio\C# Web\ASP NetCore Web apps\Spice\Spice\Spice\Areas\Admin\Views\Categories\Details.cshtml"



}

#line default
#line hidden
            BeginContext(1293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
