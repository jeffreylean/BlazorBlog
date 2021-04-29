#pragma checksum "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b06d5af21a4c12ffc66c4c26bfec61815d0e7e"
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
#line 2 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
using TechBlog.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TechBlog.Presentation.Client.Shared.Header>(0);
            __builder.AddAttribute(1, "Heading", "Jeffrey\'s Tech Blog");
            __builder.AddAttribute(2, "SubHeading", "Wonderful way to start getting smart...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row align-items-start");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 11 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
         foreach (var post in blogPosts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-4 PostPreviewItem");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<TechBlog.Presentation.Client.Pages.BlogPostPreview>(14);
            __builder.AddAttribute(15, "BlogPost", 
#nullable restore
#line 14 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
                                           post

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 16 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\projects\Blog\TechBlog\TechBlog.Presentation\Client\Pages\Index.razor"
      
    private List<BlogPost> blogPosts { get; set; } = new List<BlogPost>(); 

    protected override async Task OnInitializedAsync()
    {
        await LoadBlogPosts();
    }

    private async Task LoadBlogPosts()
    {
        var blogPostList=  await _httpClient.GetFromJsonAsync<List<BlogPost>>("/api/BlogPost/GetAllBlogPost");
        blogPosts = blogPostList.OrderByDescending(p => p.Posted).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
    }
}
#pragma warning restore 1591