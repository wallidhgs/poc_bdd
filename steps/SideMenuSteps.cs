using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    public class HighContrastOptions {
        public static string ENABLED = "enabled";
        public static string DISABLED = "disabled";
    }
    public class HighContrastDisplayed {
        public static string IS = "is";
        public static string IS_NOT = "is not";
    }

    [Binding]
    public class SideMenuSteps
    {
        private readonly IPage page;
        private readonly SideMenu sideMenu;
        
        public SideMenuSteps(IPage page)
        {
            this.page = page;
            sideMenu = new SideMenu(page);
        }
        [When(@"the high contrast option is (.*)")]
        public async Task WhenTheHighContrastOptionIs(string highContrastOption)
        {
            bool isHighContrastDisplayed = await sideMenu.LocatorIsVisible(sideMenu.CustomIcon, 1000);
            await sideMenu.MenuAccount.ClickAsync();
            if (highContrastOption == HighContrastOptions.ENABLED && isHighContrastDisplayed) {
                await sideMenu.ItemHighContrastCheck.ClickAsync();
            } else if (highContrastOption == HighContrastOptions.DISABLED && !isHighContrastDisplayed) {
                await sideMenu.ItemHighContrastCheck.ClickAsync();
            }
            await sideMenu.Refresh();
        }
        [Then(@"the website (.*) displayed in high contrast")]
        public async Task ThenTheWebsiteDisplayedInHighContrast(string highContrastDisplayed)
        {
            bool isHighContrastDisplayed = await sideMenu.LocatorIsVisible(sideMenu.CustomIcon, 1000);
            if (highContrastDisplayed == HighContrastDisplayed.IS) {
                Assert.That(isHighContrastDisplayed, Is.False);
            } else if (highContrastDisplayed == HighContrastDisplayed.IS_NOT) {
                Assert.That(isHighContrastDisplayed, Is.True);
            }
        }
    }
}
