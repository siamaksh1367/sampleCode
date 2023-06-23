namespace proj.components.Helper
{
    public class LanguageChangeEvents
    {
        public event EventHandler<string> LanguageChanged;

        internal void InvokeLanguageChanged(string newLanguage, object sender = null)
            => LanguageChanged?.Invoke(sender ?? this, newLanguage);
    }
}
