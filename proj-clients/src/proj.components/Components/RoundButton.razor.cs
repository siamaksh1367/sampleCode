using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using proj.components.Components;

namespace proj.components.Components
{
    public partial class RoundButton
    {
        [Parameter]
        public string TargetId { get; set; }
        private string _targetId;

        [Parameter]
        public RenderFragment ChildContent { get; set; }
        protected override Task OnInitializedAsync()
        {
            _targetId = "#" + TargetId;
            return base.OnInitializedAsync();
        }
    }
}