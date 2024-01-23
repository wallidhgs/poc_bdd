using PageObject;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly IPage page;
        private readonly HomePage homePage;

        public HomePageSteps(IPage page)
        {
            this.page = page;
            homePage = new HomePage(page);
        }

        [Given("User is Unsigned")]
        public async Task GivenUserIsUnsigned()
        {
            // Pending to implement kill cookies session
            await homePage.GoToPage();
        }

        [When("User is on HomePage")]
        public async Task WhenUserIsOnHomePage()
        {
            await homePage.GoToPage();
        }

        [Then("User can see Login-Button")]
        public async Task ThenUserCanSeeLoginButton()
        {
            bool btnLoginExists = await homePage.LocatorExist(homePage.BtnLogin);
            Assert.That(btnLoginExists, Is.True);
        }
    }
}