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
    [Microsoft.AspNetCore.Components.RouteAttribute("/characterList")]
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Volumes/EDUCATION/AssignmentSampleBlazorApp/Pages/CharacterList.razor"
       

    private string newProfile;
    private List<Character> profiles = new();

    private void AddProfile()
    {
        // Todo: Add the todo
        if (!string.IsNullOrWhiteSpace(newProfile))
        {
            Character newItem = new Character
            {
                Name = newProfile,
                IsFictional = false
            };
            profiles.Add(newItem);
            newProfile = string.Empty;
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
