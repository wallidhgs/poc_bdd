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
        [Given("the user has invalid credentials")]
        public void TheUserHasInvalidCredentials()
        {
            loginPage.SetCredentials("faultycreds@enroutesystems.com", "Test123");
        }
        
        [When("the user performs a log in")]
        public async Task WhentheUserPerformsALogIn()
        {
            await loginPage.DoLogin();
        }

    }
}