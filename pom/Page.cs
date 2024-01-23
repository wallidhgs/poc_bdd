using System.ComponentModel;

namespace PageObject
{
    abstract class Page
    {
        public virtual string Url { get; set; }
        private IPage page;

        public Page(IPage page)
        {
            this.Url = "https://udemy.com/";
            this.page = page;
        }

        public async Task GoToPage(){
            await page.GotoAsync(Url);
        }
        public async Task<bool> LocatorExist(ILocator locator){
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
