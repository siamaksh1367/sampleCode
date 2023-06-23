using Microsoft.AspNetCore.Components;
using proj.components.Helper;
using proj.components.Services.Local;
using proj.models;

namespace proj.components.Components
{
    public partial class Languages
    {
        private string _targetId = "LanguageBox";
        private string _imageSource;
        private List<LanguageData> _languages;
        private LanguageData? _language;
        private const string LANGUAGE_KEY = "lang";

        [Inject]
        public IStorageService _localstorage { get; set; }
        [Inject]
        public LanguageChangeEvents Events { get; set; }
        protected override async Task<Task> OnInitializedAsync()
        {
            var lang = await _localstorage.GetKey(LANGUAGE_KEY);
            lang ??= "en-US";
            _language = _languages.FirstOrDefault(x => x.Alias == lang);
            SetCulture(_language);
            return base.OnInitializedAsync();
        }

        public async Task LanguageSelectedHandler(LanguageData language)
        {
            await _localstorage.SetKey(LANGUAGE_KEY, language.Alias);
            SetCulture(language);
        }

        public void ItemCollectedHandler(List<LanguageData> languages)
        {
            _languages = languages;
        }

        private void SetCulture(LanguageData language)
        {
            L.Language = L.Languages.FirstOrDefault(x => x.Locale == language.Alias);
            _imageSource = language.Flag;
            Events.InvokeLanguageChanged(language.Alias);
        }
    }
}