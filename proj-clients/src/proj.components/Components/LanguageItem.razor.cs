using Microsoft.AspNetCore.Components;
using proj.models;

namespace proj.components.Components
{
    public partial class LanguageItem
    {
        [Parameter]
        public LanguageData Language { get; set; }
        [Parameter]
        public EventCallback<LanguageData> LanguageSelectedEvent { get; set; }
        public void OnCLick()
        {
            LanguageSelectedEvent.InvokeAsync(Language);
        }
    }
}