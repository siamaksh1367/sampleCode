using proj.components.Services.Local;

namespace proj.web.app.PlatformSpecification
{
    internal class PlatformService : IPlatformService
    {
        public string GetPlatform()
        {
            return "WEB";
        }
    }
}
