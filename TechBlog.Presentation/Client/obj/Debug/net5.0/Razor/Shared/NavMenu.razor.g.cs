#pragma checksum "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc30540ce1da71d2cf8b65e030078c0d28244e0a"
// <auto-generated/>
#pragma warning disable 1591
namespace TechBlog.Presentation.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using TechBlog.Presentation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\_Imports.razor"
using TechBlog.Presentation.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light fixed-top");
            __builder.AddAttribute(2, "id", "mainNav");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "<a class=\"navbar-brand\" href=\"/\">TechBlog</a>\r\n      ");
            __builder.AddMarkupContent(6, @"<button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        Menu
        <i class=""fas fa-bars""></i></button>
      ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "collapse navbar-collapse");
            __builder.AddAttribute(9, "id", "navbarResponsive");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "navbar-nav ml-auto");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link");
            __builder.AddAttribute(16, "href", "/");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor"
                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n          ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "addpost");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor"
                                                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Add Post\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n          ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "/samplepost");
            __builder.AddAttribute(35, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor"
                                                                NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Sample Post\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n          ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "/contact");
            __builder.AddAttribute(44, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Contact\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
