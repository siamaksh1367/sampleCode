using proj.components.Services.Local;

namespace proj.standalone.app.PlatformSpecification
{
    public class LocalStorageService : IStorageService
    {
        public async Task<string> GetKey(string key)
        {
            return await Task.Run(() => Preferences.Get(key, null));
        }

        public async Task SetKey(string key, string value)
        {
            await Task.Run(() => Preferences.Set(key, value));
        }
    }
}
