#pragma checksum "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c784308fefd8a1bb2c4b520ec4e5d74930e7b72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_Index), @"mvc.1.0.view", @"/Views/Manage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c784308fefd8a1bb2c4b520ec4e5d74930e7b72", @"/Views/Manage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdf6a9d5c203d6600f087e6a2ebc715715f1682", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EshopArmy.Models.WeaponList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
  
    ViewData["Title"] = "Manage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .add{
        color: white;
        background-color: dodgerblue;
        padding: 10px 20px;
        border-radius: 5px;
        text-decoration: none;
    }
    .add:hover{
        background-color:royalblue;
        text-decoration:none;
        color:white;
    }
</style>


<h1>Weapons</h1>

<table class=""table"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Type</th>
        <th>Price</th>
        <th>InStorage</th>
    </tr>
");
#nullable restore
#line 33 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
     foreach (var weapon in Model.Weapons)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
       Write(weapon.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
       Write(weapon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
       Write(weapon.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
       Write(weapon.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 40 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
       Write(weapon.UnitsInStorage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 859, "\"", 894, 2);
            WriteAttributeValue("", 866, "Manage/EditWeapon/", 866, 18, true);
#nullable restore
#line 41 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
WriteAttributeValue("", 884, weapon.Id, 884, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 925, "\"", 956, 2);
            WriteAttributeValue("", 932, "Manage/Delete/", 932, 14, true);
#nullable restore
#line 42 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
WriteAttributeValue("", 946, weapon.Id, 946, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\matej\Desktop\armyeshop\EshopArmy\EshopArmy\Views\Manage\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a class=\"add\" href=\"/manage/EditWeapon\">Add</a>");
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
