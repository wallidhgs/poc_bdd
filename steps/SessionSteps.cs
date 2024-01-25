using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class SessionSteps
    {
        private readonly IPage page;
        private readonly HomePage homePage;
        private readonly LoginPage loginPage;

        public SessionSteps(IPage page)
        {
            this.page = page;
            homePage = new HomePage(page);
            loginPage = new LoginPage(page);
        }

        [Given("the user is not logged in")]
        public async Task GivenTheUserIsNotLoggedIn()
        {
            // Pending to implement kill cookies session
            // await browserContext.clearCookies();
            await loginPage.GoToPage();
        }
        [Given("the user is logged in")]
        public async Task GivenTheUserIsLoggedIn()
        {
            // Pending to implement init session
            await homePage.GoToPage();
        }
    }
}