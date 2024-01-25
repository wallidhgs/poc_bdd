using Steps;
using System.Text.RegularExpressions;

namespace PageObject
{
    class SideMenu : Page
    {
        private IPage page;
        public SideMenu(IPage page) : base(page, PagePath.DASHBOARD)
        {
            this.page = page;
        }
        public ILocator MenuAccount => page.Locator("button#global_nav_profile_link");
        public ILocator ItemHighContrastCheck => page.Locator("div input[type='checkbox'] + label");
        // page.Locator("[type='checkbox']");
        // page.Locator("#u3YHbnxzZe2u");
        // page.GetByLabel("Use High Contrast UI").And(page.Locator("[type='checkbox']"));
        // page.Locator("div input[type='checkbox'] + label");

        public ILocator CustomIcon => page.Locator(".ic-app-header__logomark");
        public override async Task<bool> IsUserInPage() {
            return await LocatorIsVisible(MenuAccount);
        }
    }
}
