#pragma checksum "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1686ad5a1dfc215f632babea631f3aeac5b87011"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<TechBlog.Presentation.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n          \r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid content-layout");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
