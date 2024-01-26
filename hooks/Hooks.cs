using BoDi;
using dotenv.net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Steps
{
    [Binding]
    public class Hooks
    {
        private readonly ISpecFlowOutputHelper specFlowOutputHelper;
        private ScenarioContext scenarioContext;

        public Hooks(ISpecFlowOutputHelper specFlowOutputHelper, ScenarioContext scenarioContext)
        {
            this.specFlowOutputHelper = specFlowOutputHelper;
            this.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public async static Task BeforeTestRun(IObjectContainer container)
        {
            DotEnv.Load(options: new DotEnvOptions(probeForEnv: true, probeLevelsToSearch: 4));

            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new() {
                // Headless = false,
                SlowMo = 200,
            });
            IPage page = await browser.NewPageAsync();
            container.RegisterInstanceAs(playwright);
            container.RegisterInstanceAs(browser);
            container.RegisterInstanceAs(page);
        }

        [AfterTestRun]
        public static async Task AfterTestRun(IObjectContainer container)
        {
            IBrowser browser = container.Resolve<IBrowser>();
            await browser.CloseAsync();
            IPlaywright playwright = container.Resolve<IPlaywright>();
            playwright.Dispose();
        }

        [AfterStep()]
        public async Task TakeScreenshotAfterEachStep(IObjectContainer container)
        {
            IPage page = container.Resolve<IPage>();
            string stepNameFile = ScenarioStepContext.Current.StepInfo.Text.Replace(" ", "_");
            string scenarioNameFile = scenarioContext.ScenarioInfo.Title.Replace(" ", "_");
            var screenshotPath = $"../../../report/screenshots/{scenarioNameFile}/{stepNameFile}.png";
            var screenshotpath2 = $"./screenshots/{scenarioNameFile}/{stepNameFile}.png";
            await page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = screenshotPath,
                FullPage = true
            });
            specFlowOutputHelper.AddAttachment(screenshotpath2);
        }
    }
}
