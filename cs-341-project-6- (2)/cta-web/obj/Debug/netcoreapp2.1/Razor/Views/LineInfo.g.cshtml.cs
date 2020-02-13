#pragma checksum "/home/codio/workspace/cta-web/Views/LineInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2bd48d0833bce54bf67c809f43704bc5eac3eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_LineInfo), @"mvc.1.0.razor-page", @"/Views/LineInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/LineInfo.cshtml", typeof(program.Pages.Views_LineInfo), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/cta-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2bd48d0833bce54bf67c809f43704bc5eac3eb2", @"/Views/LineInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_LineInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
  
  ViewData["Title"] = "Lines Information";

#line default
#line hidden
            BeginContext(75, 58, true);
            WriteLiteral("\n<h2>Line Information</h2>  \n\n<br />\nYour search string: \"");
            EndContext();
            BeginContext(134, 11, false);
#line 10 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
                Write(Model.Input);

#line default
#line hidden
            EndContext();
            BeginContext(145, 30, true);
            WriteLiteral("\"\n<br />\n# of stations found: ");
            EndContext();
            BeginContext(176, 21, false);
#line 12 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
                Write(Model.LinesList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(197, 15, true);
            WriteLiteral("\n<br />\n<br />\n");
            EndContext();
#line 15 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(245, 16, true);
            WriteLiteral("\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(262, 16, false);
#line 18 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(278, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 23 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
	 }

#line default
#line hidden
            BeginContext(330, 273, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                ID
            </th>  
						<th>  
                Name
            </th>  
            <th>  
                Stops
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 41 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
         foreach (var item in Model.LinesList)  
        {  

#line default
#line hidden
            BeginContext(664, 47, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t");
            EndContext();
            BeginContext(712, 14, false);
#line 45 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
               Write(item.StationID);

#line default
#line hidden
            EndContext();
            BeginContext(726, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(795, 16, false);
#line 48 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
               Write(item.StationName);

#line default
#line hidden
            EndContext();
            BeginContext(811, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(871, 10, false);
#line 51 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
               Write(item.Stops);

#line default
#line hidden
            EndContext();
            BeginContext(881, 45, true);
            WriteLiteral("\n                </td> \n\n            </tr>  \n");
            EndContext();
#line 55 "/home/codio/workspace/cta-web/Views/LineInfo.cshtml"
        }  

#line default
#line hidden
            BeginContext(938, 26, true);
            WriteLiteral("    </tbody>  \n</table> \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LineInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LineInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LineInfoModel>)PageContext?.ViewData;
        public LineInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
