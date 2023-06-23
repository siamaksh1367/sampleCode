using Microsoft.AspNetCore.Components;

namespace proj.components.Components
{
    public partial class Item//<TData> where TData : class
    {
        [Parameter]
        public string TargetId { get; set; }
        private string _targetId;
        protected override Task OnInitializedAsync()
        {
            _targetId = "#" + TargetId;
            return base.OnInitializedAsync();
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}