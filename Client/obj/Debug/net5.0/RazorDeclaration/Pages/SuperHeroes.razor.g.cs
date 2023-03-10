// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SuperHeroDB.Client.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/superheroes")]
    public partial class SuperHeroes : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\SAMUEL OLUROTIMI\BlazingSuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
       
    SuperHeroDB.Shared.SuperHero heroToEdit = new SuperHeroDB.Shared.SuperHero();

    protected override async Task OnInitializedAsync()
    {
        await SuperHeroService.GetSuperHeroes();
        SuperHeroService.OnChange += StateHasChanged;
    }

    void ShowHero(int id)
    {
        NavigationManager.NavigateTo($"superhero/{id}");
    }

    void EditHero(int id)
    {
        heroToEdit = SuperHeroService.Heroes.Find(h => h.Id == id);
    }

    void DeleteHero(int id)
    {
        SuperHeroService.DeleteSuperHero(id);
    }

    public void Dispose()
    {
        SuperHeroService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISuperHeroService SuperHeroService { get; set; }
    }
}
#pragma warning restore 1591
