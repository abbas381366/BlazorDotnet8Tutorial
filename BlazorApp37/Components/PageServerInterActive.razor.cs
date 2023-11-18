
namespace BlazorApp37.Components;

public partial class PageServerInterActive
{
    int counter = 0;
    async Task OnStart()
    {
        for (int i = 0; i < 5; i++)
        {
            counter++;
            await InvokeAsync(StateHasChanged);
            await Task.Delay(1000);
        }
    }
}