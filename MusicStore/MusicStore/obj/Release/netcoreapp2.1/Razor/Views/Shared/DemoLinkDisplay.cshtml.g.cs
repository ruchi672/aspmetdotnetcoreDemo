#pragma checksum "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d66cb0a417026ce906dc0ef005993313c263bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DemoLinkDisplay), @"mvc.1.0.view", @"/Views/Shared/DemoLinkDisplay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DemoLinkDisplay.cshtml", typeof(AspNetCore.Views_Shared_DemoLinkDisplay))]
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
#line 1 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore;

#line default
#line hidden
#line 2 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore.Models;

#line default
#line hidden
#line 3 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d66cb0a417026ce906dc0ef005993313c263bc", @"/Views/Shared/DemoLinkDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba4a9a887ba63883abe820b8b9fdd9e64e99964", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DemoLinkDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml"
  
    ViewBag.Title = "Demo link display page - Not for production use";

#line default
#line hidden
            BeginContext(79, 34, true);
            WriteLiteral("\r\n<hgroup class=\"title\">\r\n    <h1>");
            EndContext();
            BeginContext(114, 13, false);
#line 6 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(127, 105, true);
            WriteLiteral(".</h1>\r\n</hgroup>\r\n<div>\r\n    <p>\r\n        Demo link display page - Not for production use.\r\n    </p>\r\n\r\n");
            EndContext();
#line 13 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml"
     if (ViewBag.Link != null)
    {

#line default
#line hidden
            BeginContext(271, 110, true);
            WriteLiteral("        <p class=\"text-danger\">\r\n            For DEMO only: You can click this link to confirm the email: [[<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 381, "\"", 401, 1);
#line 16 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml"
WriteAttributeValue("", 388, ViewBag.Link, 388, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(402, 149, true);
            WriteLiteral(">link</a>]]\r\n            <br />\r\n            Please change this code to register an email service in IdentityConfig to send an email.\r\n        </p>\r\n");
            EndContext();
#line 20 "E:\pulumi\aspnetcoredemoapps\aspmetdotnetcoreDemo\MusicStore\MusicStore\Views\Shared\DemoLinkDisplay.cshtml"
    }

#line default
#line hidden
            BeginContext(558, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591