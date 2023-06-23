using Microsoft.AspNetCore.Components;

namespace proj.components.Components
{
    public partial class NavButton
    {
        private string _targetId;

        [Parameter]
        public string TargetId { get; set; }

        protected override Task OnInitializedAsync()
        {
            _targetId = string.Format("#{0}", TargetId);
            return base.OnInitializedAsync();
        }
    }
}