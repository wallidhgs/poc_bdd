using Steps;

namespace PageObject
{
    class ForgotPwdPage : Page
    {
        private IPage page;

        public ForgotPwdPage(IPage page) : base(page, PagePath.LOGIN)
        {
            this.page = page;
        }

        public ILocator InputEmail => page.Locator("input, [type='text'], [id='pseudonym_session_unique_id_forgot']");
        public ILocator BtnReqPwd => page.Locator("button, [type='submit']");
        public ILocator LinkReturn2Login => page.Locator("a, .login_link");
        private ILocator PageIndicator => page.Locator("form#forgot_password_form");
        public override async Task<bool> IsUserInPage() {
            return await LocatorIsVisible(PageIndicator);
        }
    }
}
