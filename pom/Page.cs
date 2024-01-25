using Steps;

namespace PageObject
{
    abstract class Page
    {
        private string BASE_URL = $"{Environment.GetEnvironmentVariable("BASE_URL")}";
        public string url { get; set; }
        private IPage page;
        private ILocator popupContainerLocator;

        public Page(IPage page, string url)
        {
            this.url = url;
            this.page = page;
            this.popupContainerLocator = page.Locator("div#flash_message_holder");
        }

        public async Task GoToPage(){
            await page.GotoAsync($"{BASE_URL}{url}");
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
        public async Task<bool> LocatorIsVisible(ILocator locator, int timeout){
            try
            {
                await locator.WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Visible, Timeout = timeout });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public abstract Task<bool> IsUserInPage();
        
        public async Task<bool> IsPopupDisplayed(string popupTypeString){
            string innerHtml = await popupContainerLocator.InnerHTMLAsync();
            if (popupTypeString == PopupTypes.ERROR)
                return innerHtml.Contains("icon-warning");
            return false;
        }

        public async Task Refresh(){
            await page.ReloadAsync();
        }
    }
}
