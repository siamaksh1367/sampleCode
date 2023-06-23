using Microsoft.AspNetCore.Components;
using proj.components.Helper;

namespace proj.components.Components
{
    public class BaseComponent : ComponentBase
    {
        [Inject]
        public LanguageChangeEvents Events { get; set; }
        private bool _firstRender = true;
        protected override void OnAfterRender(bool firstRender)
        {
            _firstRender = false;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (_firstRender)
            {
                Events.LanguageChanged += (_, lang) => StateHasChanged();
            }
        }
    }
}
