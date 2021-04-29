#pragma checksum "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb1144e5d601f17cc9aed3e2e5e94c5136fad37"
// <auto-generated/>
#pragma warning disable 1591
namespace TechBlog.Presentation.Client.Pages
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
#nullable restore
#line 1 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
using TechBlog.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class BlogPostPreview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card post-preview-card");
            __builder.AddMarkupContent(2, "\r\n    <img src=\"img/PostPreviewDefaultPic.jpg\" class=\"card-img-top\" alt=\"...\">\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "h5");
            __builder.AddAttribute(7, "class", "card-title");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
                                blogPost.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "card-text");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
                               (MarkupString)blogPost.PostSummary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/ViewPost/" + (
#nullable restore
#line 9 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
                            blogPost.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddContent(17, "Read More");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\BlogPostPreview.razor"
      

    [Parameter] public BlogPost blogPost { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
