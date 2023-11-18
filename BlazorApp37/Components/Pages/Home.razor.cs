
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp37.Components.Pages;

public partial class Home
{
    
    public class MyFormModelClass
    {
        public string Name { get; set; }
    }
    [SupplyParameterFromQuery(Name ="idBook")]
    public string ID { get; set; }
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
    }

    [SupplyParameterFromForm(FormName = "myFormName")]
    public MyFormModelClass MyFormModel { get; set; } = new();
    [CascadingParameter] public HttpContext http { get; set; }
    int counter = 0;

    async Task OnOK()
    {

    }
    protected override void OnInitialized()
    {
        http.Response.Headers.Add("CodeEasyMS", "Abbas hasanzadeh");
    }
    protected override async Task OnInitializedAsync()
    {
        for (int i = 0; i < 5; i++)
        {
            counter += 1;
            await InvokeAsync(StateHasChanged);
            await Task.Delay(1000);
        }
    }
}