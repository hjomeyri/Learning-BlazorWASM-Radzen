#pragma checksum "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047e57c1b31e90b158c18257d6e3879d93390a23"
// <auto-generated/>
#pragma warning disable 1591
namespace LearningWASMClient.Pages.Grid
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using LearningWASMClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using LearningWASMClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Infrastructuur.Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\_Imports.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/learninggrid001")]
    public partial class LearningGrid001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Models.Unit>>(0);
            __builder.AddAttribute(1, "PagerPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.PagerPosition>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                           PagerPosition.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                              FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                                                                                 FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                                                                                                                                   4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Models.Unit>>(
#nullable restore
#line 5 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                       units

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ColumnWidth", "200px");
            __builder.AddAttribute(10, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 5 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
                                                                                                                                      LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.Unit>>(13);
                __builder2.AddAttribute(14, "Property", "Name");
                __builder2.AddAttribute(15, "Title", "name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.Unit>>(17);
                __builder2.AddAttribute(18, "Property", "LatinName");
                __builder2.AddAttribute(19, "Title", "Latin Name");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\hjome\source\repos\LearningWASM\LearningWASMClient\Pages\Grid\LearningGrid001.razor"
       

    List<Models.Unit> units = new List<Models.Unit>();

    protected override void OnInitialized()
    {

        for (int index = 1; index <= 50; index++)
        {
            var entity =
                new Models.Unit
                {
                    Name = $"واحد { index }",
                    LatinName = $"unit { index }",
                };

            units.Add(entity);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
