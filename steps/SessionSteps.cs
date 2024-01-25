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
            await page.Context.ClearCookiesAsync();
            await loginPage.GoToPage();
        }
        [Given("the user is logged in")]
        public async Task GivenTheUserIsLoggedIn()
        {
            await page.Context.ClearCookiesAsync();
            await loginPage.GoToPage();
            loginPage.SetCredentials("jesus.gaona@enroutesystems.com", "Enroute1*");
            await loginPage.DoLogin();
        }
    }
}