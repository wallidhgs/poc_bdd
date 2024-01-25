using BoDi;
using dotenv.net;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public async static Task BeforeTestRun(IObjectContainer container)
        {
            DotEnv.Load(options: new DotEnvOptions(probeForEnv: true, probeLevelsToSearch: 4));

            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new() {
                Headless = false,
                SlowMo = 2000,
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
    }
}