// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AssignmentSampleBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using AssignmentSampleBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/_Imports.razor"
using AssignmentSampleBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/Pages/Counter.razor"
       
    private int currentCount = 0;
    private int maxCount = 0;
    [Parameter]
    public int IncrementAmount { get; set; } = 1;
    [Parameter]
    public string Name { get; set; }

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }
    }
    private void ResetCount()
    {
        currentCount = 0;
    }
    private void IncreaseIncrementAmount()
    {
        if (IncrementAmount < 20)
        {
            IncrementAmount++;
        }
    }
    private void DecreaseIncrementAmount()
    {
        if (IncrementAmount > 1)
        {
            IncrementAmount--;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
