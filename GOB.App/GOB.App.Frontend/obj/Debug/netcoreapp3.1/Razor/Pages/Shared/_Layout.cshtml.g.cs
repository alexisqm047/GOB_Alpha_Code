#pragma checksum "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1399e13b903109f877c0120df2475cb12b96381c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GOB.App.Frontend.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace GOB.App.Frontend.Pages.Shared
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
#line 1 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\_ViewImports.cshtml"
using GOB.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1399e13b903109f877c0120df2475cb12b96381c", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4ace63975546714e9fe9719c990102cc36bf0f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/Secretarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/Gobernadores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/Personal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/Proveedores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c8161", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - GOB.App.Frontend</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1399e13b903109f877c0120df2475cb12b96381c8802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1399e13b903109f877c0120df2475cb12b96381c9980", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c11862", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
            <div class=""container"">
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASAAAACvCAMAAABqzPMLAAAAkFBMVEX///9BY7fuJGntDmE+YbbuH2czWrQ4XbU7X7UwWLP4+fzd4/LW3e/tAF794Or+8PXl6vVuhsbL1Ov/+/3wRnywvd/r7/dHaLrvL3FZd8D7z973oLtRcL395Oymtdy/yeXxWIfyZJGaqdV9ksv81uL1haf3qMD2k7H4r8X5wNH0e6CLndD5t8rzc5tkfsP6yNdhDgBjAAAZyUlEQVR4nO1daWOyvNKusquIuGJFxa1Wrfb//7sXCCQzyQTRqj2932fO+XA/liW5yOyTydvb/y4F2++v2XGVDKOo2WxG0TBZ7T4O7/PfHtf/AA2677PVMGoaKVmW1WSU/iv772aU7P8/ozQIDsckgsDIlOEUrWbzwW8P9Teou181fUOLDQIpmQW/PdwX03YfpeBcw0aAZPjn998e8+uoO8v4Sl4nmdQ");
                WriteLiteral(@"xfEZMIqELDH94+O2Bv4QGh1UTo5Mi41tRct7tZ1+H7+32/fvwNdunOi0yEI6Wkfz7qyj4SNDSyITw8Dx77waqHA7m24/zEKJpGcd/WxYFqeQB6KQLJNofupW3DLafCVhHRvT1orH+AgV7MNNU7Brnr3o2TvAx9I3yPv/8j+r8YN80BK/4zfNNS2F7NMq7jWH1mvubNPiM+OqxDCv5vFmWdM+l7DKi72cM8Vdpm/hAjBy3d3HJe1IsIqv5jyn8wQ6untn9ztWsgNky/il9f7CEhI0+fiRiu8PiUf6/g1BwLpePZQx/Bk/2tCNDyIr+FUl9GHLtE+0fYOUN9ux5RvJvmIx7sXyODwrslAjtHvO4X6Vg5fPl8zihUXCZ8feV/XtU6mVj/8jnnvPHWtYjn/kb9NksLbvksRI1GOYPNmYPferLaWaURsv+0d7Te/HkPy2n94X4saInmL1MUD+WcV9Lg3OBj/8UdTzIudeK/uwSGqxKi/dJH/kzf77/+ZynP58KfCzjWTMYRPkSSp70+CfT4Gw83esuzMXt017wTNr5hXh+oinXZQbEx/Pe8Dzal/g81Z9M/iyPfbzG385fYzX/XoD6m0VGnx6P6DJ/48/FhYJmgc+zR878DePPZYES5gUYz48ar6y/5o8FX7tzEVf3b/ywrf56s1m0b7pnl73KON/2ol+kwb7JU+m32s/L2EnJdjetG27KLaG/o8ZS50JkTVe33btw3EZGpj3t1b+LqbHhba/6PTqLtGnzRh9y6ZmNgpyw/hrK3TErunWgd9J4tLnEl82oeny9xWYaX05L9S/vvsCnad2k4Vsxx6fR8Ea173slQK2TZzuu6Tq2t9ZD1Np4tpte5dqOMg24gG6Mp488gU/DjGvf90KA2lObD9AOx7qrYofPw5bE6aAJS6JuG/XGhQA1aquy2ctkUG8KhyjPvaQxusoJ0R8HkMNSLXbL60P43IbTr3sf02I36oO7KHTgCBs2LQZONr5qAf8Y/AJAL7OD+njmDXNCLaG2a+K");
                WriteLiteral(@"rPPhXicWat7wfs5jZqXnb4GWW9AYvoPQjElrq7SRf5aGrjkhIH295//I+If06X2xiSlN3Q+KqWL7KOcE/byGPGTfF+VoxWEKYc6tobr3Im2950swl7mHUceWrJBh3YgndmjXvA0PxUttQ/GKf5Pl5jY4CUMNTBeVC5rCUGdBcBseyuMlf3RrEGtmlqxHXdzXOr9LyI1sBCHNPTlNlBTU8yWD6irICeb95RyKjHaaGqu15p/qORiGCXpA6XCtro2FO5YGO1WVGrLP32X52Z5y+N1oslrf48iz7/IoKj426NhqebM4Sy+wGefoM2jEOe74Iak1l9UTNXTEFaEZ8HbHE4SvMxJZDACQr+tZEvYa2Bl5FB5Z6fkE5MKHEMpcRa5M+eVGsuLW9tlYLtdr95XK0XPY1V4w77UoRtD187I/n3f6T7e3IRbTKYT3pIdlL03feFsvFREmXlMewMa2Y0TlALp5razRNkY0XxDx7o3DScOyUHLcRb5YKSP0wNVfjkyaQEBzObFNrTs3h7v07N4JkHba8pF+Ne5Kt/iYuXpq98xYNAImce8PZwGtIOSWrsfHGc82U1HhJZzOx0z+VuJqOPdlgj2vtOtmtzoTyVIP9EG+/swwrYhYpKgttbbK3mDYTja3F1HbKl2bvJL9cDaKUmGwFdkgQJVEelkvRxmHT8clTb3ftDVhFC7uYiKtGg7JcgGbrphTq2BRPyRFqT23po6ZWKOVjEhR8A+BbFxIgHHUgTKX8GrjMAKuieEknJnm44bh8uD0Yk5YG+x7pd7b6yOUTwtRbpw4wMS3Xq6V3Py3DP3JnoKe4qsVI4bMIMzp/4QVcA54DPfKlTd+beXwljgB/08VLaO9r4Uk5DNnsgBUcyirJyK6heA9Z6tznUZQO/X3RJNsNGkSoxqDLC3RgR17o8HaHCaIWjJgh7TBAkW4CISCkUejf1b3VRrKVooBVZnHupZVYSo74lOgaE/5TXNOGAPGg11gJkkBy2WhbU024Y5BU44PiBi0tKIiuZk1");
                WriteLiteral(@"YbZywQKESczdAWwFBAr6wc0LhayGoaIBoFclp0mMAgalBgFbX8IFriDR4KaqOF3yyIIrPfTy4vJ0FmJCwk1tgATmdGAIkZkMC1L4yaLsSoJ1/BZ18JmWJWV2Aqh2kbVF6wUOieHAjKJG8UlkvxY+pm48QFRxNAoQXkOk6whrKf2hUAfRVB58Uoa4WINNNSfm1KuQ0SIraHW6ht6ES8/pQZnBxeYLqAU0aSHIKICQ3G04cbsKpaYshu8xgogGaR/UaV1jJgAbIdBrhZnNpyL/bFdZQuZFIuHh9KFK8MdKV5VqcoIcvwCIzG9wkpADqwPXirDOV12qPwnLIZmGJ0wAdVQFkKe0qAJPJALmNdS8dXat3amBDw9Ursq0hMZikoDz036UxDbxZszGGDAetFgogmK6A3HhyM5/A9QosSIC2MhIpOsPzcUU0/WD8IAHkxnxonRghZE61ADGtYA1ByBgxzBRHDj02zTUW3MjtEAkiCiCIPlrYrVEYx9wdIwGSNJjlJ8WyD76GknBiqTEJIAc4hJIxPNECVLwLGujQ0cjWHvQ8nHX+YvBLNnqo04BIvQYQexhJFEBzDIKBNsTMUJayCHpggHBqD2feGrriAxZDaVowF4mlxBteL3kKpgdenEdioakoGOcai5muVjZSAM3QAjKGeDfnOxbguUxFAElshLRFBUCzYqOeWEI9yC+5aYgkTobHQpZKcNGJgVAA9eHTTWejSSpTAA1xsYgcF3vHAJ1lgOT1Cr1tORgIiMVxYXEKmgJz4IHzlCMWynoN2dI8xUgB1MOBWse7kKuIAAjXQhCpiw9Ur9WUAZITLkizVNjSip04Qiopv3GDZTKcJHstVnzly0hDMZQ8edd2TuoyIgD6vJrpR0ssS3UjgGzpLf2aAJWszWPdSIm5DGzw0wRrdbZc0KrjyokEaKl4wqbjXuTgJwHQHokgKtP/hSD8ehRAsimN5Akzi3tACKe6YKN4Z50GZdeRALVCIinp2vEaDZEACIY56ELfAPHg7FEAFRs");
                WriteLiteral(@"ceB0znGvpnV6Q0IklkZSFMMB0uVlKe/Nt0ps37QashFQBKr5jMXu6FEK+5EEAlZqMxYNQQrl0LaDaaoCiDh79gfNxy2oMGqC3PhX6zCES8loFKECzp7eEwUWWqbFHAfSWB6EKuYfSXWVBFCwlM8FyckuVjkVvNUBv7QsdczVFKSQBEBTBmhKpHeTC1QMBmg8Ny2iyGAF0PHmYHoXxKdsCBTFKNaYDKHUrLjYZ7OOlQNdWEF0tcnzWCnqb75JzV52qOSm9O00Y0ClfivR8qca0AKVDX15MKppVxoevySC6wuVZMgiNPERKrLTAyTxzajSXf0fJ6nJdVQCU3bJxiOh9wdSUFoOdFulCX+htPFCLYYBQIoDncMZUpQJ0u5ADt6kDUPrQRezJnFZ8kyt2kBVRbXW+n2MHSYOGSwHEkciskihqHceEGrsGUDbKU0NaRsxwIAD6QNOneGyFLOn35wDUp3jljU4FmSb3gbEUL0K8NQDKlxESRsz0IgCaY1dLXULfyFnL+uQ8AyCkxECap0cIIRck3NEKK/JntQBKp7GGfMbQJQAaoHiGaksHQ+XvzwAI1S144JlEqhnmq06EN1YTIDlI1KEBkpwxuZAswBnF3FJ6BkBIiZngNqJYAVYtIhYsWJMGaLm5hCNpPCjR3NcAtJUiignkMilexjzLJwCEhC0qF5N3b0g7BJCeL1w4Mu0T2q7r2maIhgsZVAsQDmdkcmhfQtQ9SmF75qw9AaA2dlVhEEKx61A+Emm/IqhIAVT48qbjnsSYYLmjnsWKGkSAkBGt9p9fH7ukqeSDuk8CCK0TXFKmKHobhuhwSSdbegRAIhpkOo1TwaJjFAHRCek3bCkziPKW7mq1UOHtPwGgBSFKCpIjXaYD1xfW8wwNAiAk4hxvehotRycT4sOMUxqg93qJVR7begJAGyViz0kuq5IqfpH6Y2qMAEgyyN2snhLzrr3WA8R7oF2hMjr6BICmOi3/hkONCnx4ZwtbewRAlbVB7Lqq4oVBjeoXEE57PEA");
                WriteLiteral(@"oMijvTEHsp+y0RXqerS4CIF0dnJhGUY+qKX8JapQvGEmZJn4CQIgFpG2YHeRYomLEN1nPXzQAVZXf5ZdNxpUAvc2b1xACHW8fDxD25eW9B4jH5Dwc2oPH9F8PAcQW3JqMm/CrSq5G70IlcvOomstgC0LVfAAEv2hFZlUiZNLKu1eQO+HIrgOqKmRTAh+Q7wpee/o15Ir0OZT5+NuLZrkEWT5KmIHpmHKRFCoxrb0rFqW85ALuHuAxV9knCatkWKEhRFRYlSOlfIlfEwvLCkQV5FcNZtrDkYwIx2JBAwdHKQEC1petL6OQCGSt1Ce+LcT7PCVjDPbhlmuvx39ywffrhS65m8iBhfbi45vqq7YJWUluWGc5CMIHULI4IFHL5d6w63NclOubtrLDMKWNVxaCESVZnUbhRoji9b7rFJNHk8yirVidmY49xbnzVlwMxKO+7iGRz5HKztNS063tYkyuinK2vtxidLUbF2QDW9uebXsO3dBkFKd/zP5K/bG38bJbJ2AsvTC//iJ/vtZyM0kvdhzXdbKNqdO1Eg1pnZSnQcrP2srPacv8Dd8fzsj2MuNNPoApufmpH3vZ25XRXaFWfzTqa3fBtJejZUf311b2R/xTb7QY0QMYLxfr02lzWi/6tA5pLRcL/UBShfa5PyfJMFkd91/6bZj6AaTUX5wWdds6/E0aDILB32ub+B/9R//Rf/Qf/R3ZPWD0ylemFsDxfD7uq44sG3zPdufVeTd7rze0YN6tIvlN3dl5tfu69ujgsD8Po+xoPitKjrPDa1D6TJgNmfVVSTR9VbY7yy+vae6v9jAMmF1aQX40A7MbnLMRpP+vauvCjV3mC7DxVph0D6KvCJ8zSvVAn698WAsBd+yS1B1ePyHXApk6nsa0fF2/sMEhofZuW485D0pP4mQu8Uql0uFLCSpVH5IYDOuEetOHlDCDUi7NuXDftMOdj3f4xP415FTkquoPYmxGVNFDbF8LH9Fe7h2WulG9pYJj1dbt5x0codvzi9fQJxlxqzq");
                WriteLiteral(@"x5Prp3OUz2PVoY5ulFqIcroRFdTWGGY17vevhz9ZY48Pq9ozD0/2+NdcY2v6U3ZoLKH0PAwNlONV2NPurAs2i+7C1F6HpOo5rXtToB6fO4pJtPG2EhI/+pZsJ6GsWDLXxSF1jnff6AL2rr1Bqlnc1HkdViPXDRt6JJCXXcS9kEKu1vLjsooZrN0IJRjgwC6ekxZ5usKtKukbb4vTWFSQBJOmxWju31U514xOqDDZde6OyWjuERY2m4+DmOWABGcn+cw8EtqjNF5k1Kzp/zlYgj+TrpNDVXFP5xKbyoRSAZvWyw/JJckS/E0eJFI8cqYrLtGO4iESRIhvUQCxm3ndJsEthtryL2Wu77s/qarH9VYA+6j1Kbp7cd6nOLDZG6ERkjFA8mT+ezxRIy0Caa7l3HNQ2ahsMXm+Iwe4v7KAKgLo1F6PE7nLX3HL2KHGwIOpIQa4xfTk/+peX54mSorLxEtdzPrcMOdOVfNi/TDb428yTLPp9ZU78VMIKgCgNwYp48OPxZouWptcOylf1NVlrl9fB8eoYodS3/I2FAuZrCnyilQRQP9WjjnTUQPAxjArSATSclSJMDxBhghnWcLXb785JZAD1MUTW5UKbj57wYSIQUTcLu8wylQAB/v0WElkCCOh0Pp2CxfIKC6WtU+rN5xTgQjf/UHjzwBzUAhQoDGb4+9KCD76PRuEhlhtnyrmLyiPT9jwPbpHl6W/AYK5nxjaQR+Vu1LmljEhInNJO3pXHMPFPNBBsyG5kOUtNj3HZKvKJmn8tQIrLYhyx4jycU4x8/4x/FUlr1x2N38YjsUB4DQnYJ+uE2bLqi0Qur7JIii3c4vFcvHCOKkQykMdiM2zR36tIWCupdxogwsnVAaQU7xAeRfD9qQQ8QjlB3eZo8JIDsYDKLL/op88LN7ZRJkrBFxPdYsSP5/waUQMy4LMpm6YXpSVq+cFPAZJVfE2fdFzWApmNUiFxOHh5Na/LEcPu84XGKyO252GUCMsefDHBCYNZEg1BEl/YONyYLKq");
                WriteLiteral(@"YbLqt0P0ASUWodXts8/UiKkDanH2KKhtRvAWS7LxcDVSvBHMg/oGdCM2KQQDWMOiYIpqmr222Msm0990AdfH6qd33mtdm25zpecFoyT1cTEHTiJfIKMVRjMBOe1/XxR3MxUjEz4x96aMO7gZIssetumGxcgWBijbe9arc88jFFCybEHV6pMb5BmtDG8mAJjKYarERnuz+fDdAmMPqn2FVltsB5lkL5mHfkEtt1GCCl6FRTcjm0CvVxVOB3sV+xog9mqo8uxsgqf1K/aghE8mu6IQqSiXLVSU6asJFLxhPqih9w3tctQeLgp5oFj5embXhIkvz7gVI7g91Q2h+k5XpgEpEUXNd8I4oB0WdkECdnvJMGDbXteCGlfv49KrCbifb490LELbArZuOQeivTwsR2QF9XIuqYF6RipeKwE051ALU5Et+jSDYM06KixYK0qRK8+4FCHVn+cnRBKAEuPyCvLZUKpykOQ8Phtq9qUxDGm7xPtrbuBcgHGn9QeJCnKjE23cLgPCaFwDh6OM3cAq1kWagwCQtN2Y6jChjzehegHBCwb879wV7LK/l36TiSGE+Il6AvKM9CQl8ULnNO2Mwc0LXvt4LENqULfV1voH6oOkkl8gCIGyYCO0PHcsB5B3dmUugX5UldSMqttBShbEZ3QsQNoOo++pQD4R6REfGmwCC8VGxsUUi2PRUNrPZAtIw2C8DBE+FAocm6ljMpFjsqOcdTlBI+bK4zO1P2s3I6DdZDLangr60Tkjz0BoQ0sA4tnRHcyIhpfjUSy/LzGlbGD5ISN91/AfYC4ROV+UWoXQyA6HmvyA+Gk2BhBRhRS5SE1rf/vZegKR9//ccowf3w5hQcdc3FOHmeq2psbompFpVB548yFC88cC1jJZyg09O42uuRvlzFyRPtCf5QSGV3D7MB7kayc1lUqCTsilLANoi5IHH0qedw+R88iHoAKxp1GdnL6753Nbzjh7krBq3qrHxRO6pC4i796iDMA8pFrIb7/m1YAFhc1/O/gsHHSA");
                WriteLiteral(@"ltcb8qHDHjc5Y6wJ23ykmyIYMmMmwEQ25OVplF8RuRW2OUevE7rsBwnr+1nPQQiGgiVMfuZ6H5+eAkGtbHbmMUBE0q8yy1/qqdwOEpfSNSwic+evGqgoRBjZ1dEUR16quJGTeYVBZfFJLZt8ftJc61DRvkEKgLQG9P/IiwCjF9FLeAvoAgOqcEn1/2gfzmD5QpdJShMjMSf+tVZK4QphIpQXZ5wnrsseBtgAvH03BYpWdCZ7LYsqpF2QB7Fugxq/g0R1mHAra8PO/wI5+Jx71Wu21MJpKmT6oqh31C8Pso6L+VhtbexBASnmkqjezDQC+v8KOGm6bkh8NUpBj81aXYId3XuEA9+SXPBkk2u0CPjdcZ5buIr+qVPoRAKnld1YTltUHh4SVwBgWTDO05B7ckNz46lUeCIF0P2YkfcDilAN9zaym+/gDgAYKg1tGdDzMgyCYdz/PYr+DBc+rVpt/QeIldtpTz8IKv+kZ9AOAqLN3sp0+0TCKpIpbkJemS+tKEmqdBtJVz+V8Mv0EII0ZRpT3gedqjzNjAAnfgjrZztEEjp9IPwKoTn8fdpcIRaA+sDKZJmCgdizVKZreq/nr7YcAsdMA6wAE7lpk1eHp/xg1wL/lwF5rDdp+ZJ3wpcRVjW0eFdSqd/vPAKpbc42CWcswnpAUh/KGhPYpzvpZpMjZ7mWBJ9QP4zhc9O5bU6lldYnjTY0uFT8EqObeKum5416bIkq+jPvr8DK9bEZyg4xlduitazvh4vZTituLi50dBeeY1/uc/KCIk1HlMZ/lTcnNc7hGZVg2XVzedH1LP5f+euqVmxxM7yqbzTFAlLdwZTvU51U5ZBGbzH5KsGeV6Xh2qCwxglqdUYgbFdY4ED7S2CuCUBqemOv2yhZPq/n4TZny6aQps5nx5bRsa2RSq9densLYlE8fMIlgi0RQzNKlR9urWzL3VgVExlBXMfgD6qlN5TMlaDvxJTwtRv32uKTOcrQ4hZfYtaUDKAu6ChDYF6srxASxTU155HZlaCA");
                WriteLiteral(@"y5Oryx5D+fNuih5PnODnvZW2bckVIX1+n3xvvxGeQvfUzSgpBbGm3WL1ts50Hyg5t3zjeW9Zwha72sGTG1bWLNMXRmIId8/8rPvW+6ed9AqqYZfB5HPp+0UYrbysQnat6RfyMeo2rCNUg9zqH5RR87HezSk0TfKVXXM0kBfOv/XG1SpJV1kdr/tSWAu2LcgjFjZQK9vDlrl1Or+lsku34rXu6M0XEOWf/HHVOjn0fRo5tEifl/YvUX8epXXwLSJntPTndYnv/dWqvw0k9kDJTyTPDf7xVIEGt8fJ0iZ3cFNTYO7kZ6cbhuq/rc/HPU68zSlGamE5mGBZAmVnWxMkE1SQOU0fk1fHa/0Ead/rLxWkTTuPJpDGJ42m4OS2W/ZrQ/B8F5uo1BvNMsQAAAABJRU5ErkJggg=="" width=""100"" height=""70"" >
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c22361", async() => {
                    WriteLiteral("Inicio");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c23986", async() => {
                    WriteLiteral("Secretarios");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c25616", async() => {
                    WriteLiteral("Gobernadores");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c27247", async() => {
                    WriteLiteral("Personal de aseo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c28882", async() => {
                    WriteLiteral("Proveedores");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 43 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2021 - GOB.App.Frontend - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c31031", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c32503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c33604", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1399e13b903109f877c0120df2475cb12b96381c34705", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#nullable restore
#line 55 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 57 "C:\GOB_Alpha_Code\GOB.App\GOB.App.Frontend\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
