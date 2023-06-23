using Blazored.LocalStorage;
using proj.components.Services.Local;

namespace proj.standalone.app.PlatformSpecification
{
    public class LocalStorageService : IStorageService
    {
        private readonly ILocalStorageService _localStorageService;

        public LocalStorageService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }
        public async Task SetKey(string key, string value)
        {
            await _localStorageService.SetItemAsStringAsync(key, value);
        }

        public async Task<string> GetKey(string key)
        {
            return await _localStorageService.GetItemAsStringAsync(key);
        }
    }
}
