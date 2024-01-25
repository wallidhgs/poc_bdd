using System.Configuration;
using Steps;

namespace PageObject
{
    class HomePage : Page
    {
        private IPage page;
        public HomePage(IPage page) : base(page, PagePath.DASHBOARD)
        {
            this.page = page;
        }
        private ILocator PageIndicator => page.Locator("div#dashboard");
        public override async Task<bool> IsUserInPage() {
            return await LocatorIsVisible(PageIndicator);
        }
    }
}
