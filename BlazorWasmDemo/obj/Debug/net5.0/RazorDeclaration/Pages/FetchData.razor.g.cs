// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWasmDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using BlazorWasmDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\_Imports.razor"
using BlazorWasmDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\mateu\source\repos\Api.ShopSolution\BlazorWasmDemo\Pages\FetchData.razor"
       
    private ICollection<BlazorWasmDemo.WeatherForecast> forecasts;

    protected override async Task OnInitializedAsync()
    {
        swaggerClient Client = new("https://localhost:44313/", Http);
        forecasts = await Client.WeatherForecastAsync();
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
