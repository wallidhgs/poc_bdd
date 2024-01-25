using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly string INSTRUCTOR_EMAIL = $"{Environment.GetEnvironmentVariable("INSTRUCTOR_EMAIL")}";
        private readonly string INSTRUCTOR_PWD = $"{Environment.GetEnvironmentVariable("INSTRUCTOR_PWD")}";
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
            loginPage.SetCredentials(INSTRUCTOR_EMAIL, INSTRUCTOR_PWD);
        }
        [Given("the user has invalid credentials")]
        public void TheUserHasInvalidCredentials()
        {
            loginPage.SetCredentials("invalidcreds@enroutesystems.com", "Test123");
        }
        
        [When("the user performs a log in")]
        public async Task WhentheUserPerformsALogIn()
        {
            await loginPage.DoLogin();
        }

    }
}