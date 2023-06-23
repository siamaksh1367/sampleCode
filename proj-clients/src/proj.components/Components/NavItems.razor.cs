using Microsoft.AspNetCore.Components;
using proj.components.Services.Local;
using proj.models;

namespace proj.components.Components
{
    public partial class NavItems
    {
        private List<NavItemData> _items;

        [Inject]
        public ILocalService<NavItemData, NavItems> Service { get; set; }
        protected override Task OnInitializedAsync()
        {
            _items = Service.GetData();
            return base.OnInitializedAsync();
        }
    }
}