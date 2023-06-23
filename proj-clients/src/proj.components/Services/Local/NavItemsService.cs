using proj.components.Components;
using proj.models;

namespace proj.components.Services.Local
{
    public class NavItemsService : ILocalService<NavItemData, NavItems>
    {
        public List<NavItemData> GetData()
        {
            return new List<NavItemData>()
            {
                new NavItemData() {Link="/home", Text="Nav_Home"},
                new NavItemData() {Link="/pay", Text="Nav_Pay"},
                new NavItemData() {Link="/earn", Text="Nav_Earn"}
            };
        }
    }
}
