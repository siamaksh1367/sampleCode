using proj.components.Components;
using proj.components.Helper;
using proj.models;

namespace proj.components.Services.Local
{
    public class LanguageService : ILocalService<LanguageData, Languages>
    {
        public List<LanguageData> GetData()
        {
            return new List<LanguageData> {
             new LanguageData(){Alias="en-US" , Flag= Images.EN.ImageToBase64(), Name="English" , Value="En"},
             new LanguageData(){Alias="fa_IR" , Flag= Images.FA.ImageToBase64(), Name="farsi" , Value="Fa"}
            };
        }
    }
}
