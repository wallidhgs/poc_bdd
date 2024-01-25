namespace PageObject
{
    abstract class Page
    {
        string BASE_URL = $"{Environment.GetEnvironmentVariable("BASE_URL")}";

        public virtual string Url { get; set; }
        private IPage page;

        public Page(IPage page)
        {
            this.Url = BASE_URL;
            this.page = page;
        }

        public async Task GoToPage(){
            await page.GotoAsync(Url);
        }

        public async Task<bool> LocatorIsVisible(ILocator locator){
            try
            {
                await locator.WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Visible});
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
