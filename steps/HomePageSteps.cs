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

        [When("User is on HomePage")]
        public async Task WhenUserIsOnHomePage()
        {
            await homePage.GoToPage();
        }
    }
}