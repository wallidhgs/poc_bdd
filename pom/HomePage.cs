namespace PageObject
{
    class HomePage : Page
    {
        private IPage page;

        public HomePage(IPage page) : base(page)
        {
            this.page = page;
        }

        public ILocator PageIndicator => page.Locator("div#dashboard_header_container");
        
        public async Task<bool> IsUserInPage() {
            return await LocatorIsVisible(PageIndicator);
        }
    }
}
