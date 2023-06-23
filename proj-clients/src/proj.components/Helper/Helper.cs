namespace proj.components.Helper
{
    public static class Helper
    {
        public static string ImageToBase64(this byte[] image)
        {
            return "data:image/png;base64," + Convert.ToBase64String(image);
        }

        public static string ImageToUrl(this byte[] image)
        {
            return "url(data:image/svg+xml;base64," + Convert.ToBase64String(image) + ")";
        }
    }
}
