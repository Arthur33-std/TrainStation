// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TrainStationUI.Pages.Flight
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using AirlineUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\_Imports.razor"
using AirlineUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\Pages\Flight\Flight.razor"
using AirlineUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\Pages\Flight\Flight.razor"
using AirlineUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/flight")]
    public partial class Flight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\art\Desktop\Airline\Airline\AirlineUI\Pages\Flight\Flight.razor"
       
   IEnumerable<FlightViewModel> flights;

    protected override async Task OnInitializedAsync()
    {
      flights=await flightService.GetAllFlightAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService flightService { get; set; }
    }
}
#pragma warning restore 1591
