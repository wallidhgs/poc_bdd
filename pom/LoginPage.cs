namespace PageObject
{
    class LoginPage : Page
    {
        private IPage page;
        private string usr;
        private string pwd;

        public LoginPage(IPage page) : base(page)
        {
            this.page = page;
            this.usr = "";
            this.pwd = "";
        }

        public ILocator InputEmail => page.Locator("input#pseudonym_session_unique_id");
        public ILocator InputPwd => page.Locator("input#pseudonym_session_password");
        public ILocator BtnLogin => page.Locator("button[type='submit']:has-text('Log In')");
        public ILocator LinkForgotPwd => page.Locator("a#login_forgot_password");

        public void SetCredentials(string usr, string pwd) {
            this.usr = usr;
            this.pwd = pwd;
        }
        public async Task DoLogin() {
            await InputEmail.FillAsync(this.usr);
            await InputPwd.FillAsync(this.pwd);
            await BtnLogin.ClickAsync();
        }
    }
}
