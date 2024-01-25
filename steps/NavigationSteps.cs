using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class NavigationSteps
    {
        private readonly IPage page;
        private readonly HomePage homePage;
        private readonly LoginPage loginPage;

        public NavigationSteps(IPage page)
        {
            this.page = page;
            homePage = new HomePage(page);
            loginPage = new LoginPage(page);
        }

        [Then(@"the user should be redirected to (.*) page")]
        public async Task ThenTheUserShouldBeRedirectedToPage(string pageName)
        {
            bool isUserInPage = false;
            if (pageName == PageNames.DASHBOARD)
                isUserInPage = await homePage.IsUserInPage();
            else if (pageName == PageNames.LOGIN)
                isUserInPage = await loginPage.IsUserInPage();
            Assert.That(isUserInPage, Is.True);
        }
        [Then(@"the page should display (.*) popup")]
        public async Task ThenThePageShouldDisplayAPopup(string popupType)
        {
            bool isCorrectPopupType = false;
            if (popupType == PopupTypes.ERROR)
                isCorrectPopupType = await loginPage.IsPopupDisplayed(PopupTypes.ERROR);
            Assert.That(isCorrectPopupType, Is.True);
        }
    }
}
