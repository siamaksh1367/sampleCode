using proj.components.Services.Local;

namespace proj.standalone.app.PlatformSpecification
{
    internal class PlatformService : IPlatformService
    {
        public string GetPlatform()
        {
            return DeviceInfo.Current.Platform.ToString();
        }
    }
}
