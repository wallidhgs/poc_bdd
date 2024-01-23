namespace PageObject
{
    class HomePage : Page
    {
        private IPage page;

        public HomePage(IPage page) : base(page)
        {
            this.page = page;
        }

        public ILocator BtnLogin => page.Locator("[data-purpose='header-login']");
    }
}
