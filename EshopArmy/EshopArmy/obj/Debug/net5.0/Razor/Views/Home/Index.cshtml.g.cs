#pragma checksum "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c69e472d98fcc6b453680f5883a49380658f438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\_ViewImports.cshtml"
using EshopArmy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\_ViewImports.cshtml"
using EshopArmy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c69e472d98fcc6b453680f5883a49380658f438", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdf6a9d5c203d6600f087e6a2ebc715715f1682", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EshopArmy.Models.WeaponList>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c69e472d98fcc6b453680f5883a49380658f4383322", async() => {
                WriteLiteral(@"

    <style>

        main {
            width: 1200px;
            margin: 0 auto;
        }
        .weapon {
            display: grid;
            grid-template-rows: 150px 50px 1fr;
            grid-template-columns: 1fr;
            margin: 5px;
        }

        .weapon img {
                align-self: center;
                width: 100%;
                height: 100%;
                object-fit: cover;
        }
        .headerOfProduct {
            flex: 1;
            flex-grow: 0;
        }
        .block{
            display:grid;
            grid-template-columns: 1fr 1fr 1fr;
        }
        .price{
            color: red;
            flex:1;
            font-weight:bold;
        }
        .name{
            flex:1;
            align-self:flex-start;
            margin:0;
        }
        .headerOfProduct{
            display:flex;
            flex-direction:column;
        }
        .block a:hover{
            background-color:lightgray;
      ");
                WriteLiteral("  }\r\n    </style>\r\n\r\n\r\n    <main>\r\n");
#nullable restore
#line 58 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
         for(int ii = 0; ii < Model.Weapons.Count; ii= ii + 3)
        {          

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"block\">\r\n");
#nullable restore
#line 61 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
             for (int i = 0; i < 3; i++)
            {
                if (i + ii < Model.Weapons.Count)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 1417, "\"", 1477, 2);
                WriteAttributeValue("", 1424, "/detail/DetailWeapon/", 1424, 21, true);
#nullable restore
#line 65 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
WriteAttributeValue("", 1445, Model.Weapons.ToList()[i+ii].Id, 1445, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"text-decoration: none !important; color:black!important; \">\r\n                        <div class=\"weapon\">\r\n\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1627, "\"", 1672, 1);
#nullable restore
#line 68 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
WriteAttributeValue("", 1633, Model.Weapons.ToList()[i + ii].Picture, 1633, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"img missing\" />\r\n                            <div class=\"headerOfProduct\">\r\n                                <h4 class=\"name\">");
#nullable restore
#line 70 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
                                            Write(Model.Weapons.ToList()[i + ii].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h4>\r\n                                <span class=\"price\">");
#nullable restore
#line 71 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
                                               Write(Model.Weapons.ToList()[i + ii].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" kč</span>\r\n                            </div>\r\n                            <p>");
#nullable restore
#line 73 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
                          Write(Model.Weapons.ToList()[i + ii].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 76 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <hr>\r\n");
#nullable restore
#line 80 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EshopArmy.Models.WeaponList> Html { get; private set; }
    }
}
#pragma warning restore 1591