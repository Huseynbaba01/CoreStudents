#pragma checksum "C:\Users\Acer\source\repos\StudentsApplication\Views\Home\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91163a738447987cf860b650dd6f1acff94991f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddStudent), @"mvc.1.0.view", @"/Views/Home/AddStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91163a738447987cf860b650dd6f1acff94991f3", @"/Views/Home/AddStudent.cshtml")]
    #nullable restore
    public class Views_Home_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Acer\source\repos\StudentsApplication\Views\Home\AddStudent.cshtml"
  
    ViewData["Title"] = "AddStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form action=""add"" method=""post"">

  <div class=""container"">
      <div>
          <p>&nbsp;</p> <p>&nbsp;</p> 
    <label for=""uname""><b>NAME</b></label>
    <input type=""text"" placeholder=""Enter Name"" name=""NAME"" required>

      </div>
      <p>&nbsp;</p>
      <div>
          <label for=""surname""><b>SURNAME</b></label>
    <input type=""text"" placeholder=""Enter Surname"" name=""SURNAME"" required>
</div>
<p>&nbsp;</p>
      <div>
          <label for=""degree""><b>DEGREE</b></label>
    <input type=""text"" placeholder=""Enter Degree"" name=""DEGREE"" required>
</div>
  <p>&nbsp;</p>
   <div>

    <button type=""submit"" class=""btn btn-primary"">Add</button>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
