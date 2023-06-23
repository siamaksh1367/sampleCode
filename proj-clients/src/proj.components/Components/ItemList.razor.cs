using Microsoft.AspNetCore.Components;
using proj.components.Services.Local;

namespace proj.components.Components
{
    public partial class ItemList<TData, SComponent> where TData : class where SComponent : ComponentBase
    {
        private List<TData> _items;

        [Parameter]
        public string TargetId { get; set; }

        [Parameter]
        public RenderFragment<TData> ItemPresentation { get; set; }

        [Inject]
        public ILocalService<TData, SComponent> Service { get; set; }

        [Parameter]
        public EventCallback<List<TData>> ItemsCollcetedEvent { get; set; }

        protected override Task OnInitializedAsync()
        {
            _items = Service.GetData();
            ItemsCollcetedEvent.InvokeAsync(_items);
            return base.OnInitializedAsync();
        }
    }
}