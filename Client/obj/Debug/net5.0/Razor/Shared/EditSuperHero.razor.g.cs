#pragma checksum "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2883da4b52ad2ac814d4da631585bbfdac62321"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperHeroDB.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Shared;

#line default
#line hidden
#nullable disable
    public partial class EditSuperHero : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
 if (Hero.Id == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Create a new Hero</h3>");
#nullable restore
#line 7 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Edit \'");
#nullable restore
#line 10 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
__builder.AddContent(3, Hero.HeroName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "\'");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 13 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                 Hero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                 HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label>First Name</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                Hero.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hero.FirstName = __value, Hero.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hero.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label>Last Name</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                Hero.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hero.LastName = __value, Hero.LastName))));
                __builder2.AddAttribute(25, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hero.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label>Hero Name</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 24 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                Hero.HeroName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hero.HeroName = __value, Hero.HeroName))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Hero.HeroName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label>Comic</label><br>\r\n        ");
                global::__Blazor.SuperHeroDB.Client.Shared.EditSuperHero.TypeInference.CreateInputRadioGroup_0(__builder2, 39, 40, "form-control", 41, 
#nullable restore
#line 28 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                      comicId

#line default
#line hidden
#nullable disable
                , 42, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => comicId = __value, comicId)), 43, () => comicId, 44, (__builder3) => {
#nullable restore
#line 29 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
             foreach (var comic in SuperHeroService.Comics)
            {

#line default
#line hidden
#nullable disable
                    global::__Blazor.SuperHeroDB.Client.Shared.EditSuperHero.TypeInference.CreateInputRadio_1(__builder3, 45, 46, 
#nullable restore
#line 31 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
                                    comic.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenElement(47, "span");
                    __builder3.AddAttribute(48, "style", "padding-left: 5px;");
#nullable restore
#line 31 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
__builder3.AddContent(49, comic.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "<br>");
#nullable restore
#line 32 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Shared\EditSuperHero.razor"
       
    //[Parameter]
    //public SuperHeroDB.Shared.SuperHero HeroToEdit { get; set; }

    [Parameter]
    public SuperHeroDB.Shared.SuperHero Hero { get; set; } = new SuperHeroDB.Shared.SuperHero();
    int comicId = 1;

    protected override async Task OnParametersSetAsync()
    {
        await SuperHeroService.GetComics();
        comicId = Hero.ComicId;
    }

    async void HandleSubmit()
    {
        Hero.Comic = null;
        Hero.ComicId = comicId;

        await JSRuntime.InvokeVoidAsync("console.log", Hero);

        if (Hero.Id == 0)
        {
            await SuperHeroService.CreateSuperHero(Hero);
        }
        else
        {
            await SuperHeroService.UpdateSuperHero(Hero, Hero.Id);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISuperHeroService SuperHeroService { get; set; }
    }
}
namespace __Blazor.SuperHeroDB.Client.Shared.EditSuperHero
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
