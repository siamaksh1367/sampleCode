namespace proj.components.Services.Local
{
    public interface IStorageService
    {
        Task SetKey(string key, string value);
        Task<string> GetKey(string key);
    }
}
