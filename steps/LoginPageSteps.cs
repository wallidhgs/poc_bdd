using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly IPage page;
        private readonly HomePage homePage;
        private readonly LoginPage loginPage;

        public LoginPageSteps(IPage page)
        {
            this.page = page;
            homePage = new HomePage(page);
            loginPage = new LoginPage(page);
        }

        [Given("the user has valid credentials")]
        public void TheUserHasValidCredentials()
        {
            loginPage.SetCredentials("jesus.gaona@enroutesystems.com", "Enroute1*");
        }
        [When("the user performs a log in")]
        public async Task WhentheUserPerformsALogIn()
        {
            // Pending to implement kill cookies session
            // await browserContext.clearCookies();
            await loginPage.DoLogin();
        }
        [Then(@"the user should be redirected to (.*) page")]
        public async Task ThenTheUserShouldBeRedirectedToDashboardPage(string pageName)
        {
            Console.WriteLine($">>pageName: {pageName}");
            bool isUserInPage = await homePage.IsUserInPage();
            Assert.That(isUserInPage, Is.True);
        }
    }
}