#pragma checksum "C:\Users\пк\Desktop\Airline\AirlineUI\Pages\Новая папка2\Passenger.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3664a86d8f61c64ebc7475cdabe459157033687"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AirlineUI.Pages.Новая_папка2
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using AirlineUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\пк\Desktop\Airline\AirlineUI\_Imports.razor"
using AirlineUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\пк\Desktop\Airline\AirlineUI\Pages\Новая папка2\Passenger.razor"
using AirlineUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\пк\Desktop\Airline\AirlineUI\Pages\Новая папка2\Passenger.razor"
using AirlineUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/passenger")]
    public partial class Passenger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\пк\Desktop\Airline\AirlineUI\Pages\Новая папка2\Passenger.razor"
       
   IEnumerable<PassengerViewModel> passengers;

    protected override async Task OnInitializedAsync()
    {
       passengers=await passengerService.GetAllPassengerAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService passengerService { get; set; }
    }
}
#pragma warning restore 1591
