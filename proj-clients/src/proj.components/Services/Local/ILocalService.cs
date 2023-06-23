using Microsoft.AspNetCore.Components;
using System.Collections;

namespace proj.components.Services.Local
{
    public interface ILocalService<TData, SComponent> where TData : class where SComponent : ComponentBase
    {
        List<TData> GetData();
    }
}
