#pragma checksum "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba9d51001693955c20bfd86e54f080a95583aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Questionario), @"mvc.1.0.view", @"/Views/Quiz/Questionario.cshtml")]
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
#line 1 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\_ViewImports.cshtml"
using ProjetoQuiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\_ViewImports.cshtml"
using ProjetoQuiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba9d51001693955c20bfd86e54f080a95583aa4", @"/Views/Quiz/Questionario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec31539a60c1a59b6e078b49629eba8f7c7360d", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Questionario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoQuiz.Models.Quiz>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Questionário</h1>\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
         using (Html.BeginForm("Quiz", "", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 15 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <input type=\"radio\" name=\"1\" value=\"1\" />\r\n            <label> ");
#nullable restore
#line 17 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Question1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label><br />\r\n            <input type=\"radio\" name=\"2\" value=\"2\" />\r\n            <label>");
#nullable restore
#line 19 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
              Write(Html.DisplayFor(modelItem => item.Question2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label><br />\r\n            <input type=\"radio\" name=\"3\" value=\"3\" />\r\n            <label> ");
#nullable restore
#line 21 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Question3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n            <input type=\"radio\" name=\"4\" value=\"4\" />\r\n            <label> ");
#nullable restore
#line 23 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Question4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</label><br />\r\n");
#nullable restore
#line 24 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"



        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\mesilva\source\repos\ProjetoQuiz\Views\Quiz\Questionario.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"submit\" value=\"Enviar Respostas\" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoQuiz.Models.Quiz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
