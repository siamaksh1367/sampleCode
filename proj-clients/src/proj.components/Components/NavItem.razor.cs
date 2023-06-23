using Microsoft.AspNetCore.Components;

namespace proj.components.Components
{
    public partial class NavItem
    {
        [Parameter]
        public string Link { get; set; }
        [Parameter]
        public string Text { get; set; }

    }
}