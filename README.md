# QA 101 Final Project BDD

BDD version of the project [QA101_final_project_csharp][project_csharp]

## Dependencies

This project requires [.NET 8.0](https://dotnet.microsoft.com/es-es/download/dotnet/8.0) or above

```sh
dotnet restore
```

## Running the tests

For first time runs you may need to download browsers for playwright. The easiest way to do this is by [downloading powershell](https://github.com/PowerShell/PowerShell/releases/tag/v7.4.1) and then run the following command:

```sh
pwsh bin/Debug/netX/playwright.ps1 install
```

_Note: replace "netX" with the actual output folder name, e.g. net8.0. Visit [playwright docs page](https://playwright.dev/dotnet/docs/intro) for more info_

Run the tests with:

```sh
dotnet test
```

## Chrome profile

- Windows 7, 8.1, and 10 \
   `C:\Users\<username>\AppData\Local\Google\Chrome\User Data\Default`
- Mac OS X El Capitan \
   `Users/<username>/Library/Application Support/Google/Chrome/Default`
- Linux \
   `/home/<username>/.config/google-chrome/default`

> Replace `<user>` with your username \
> chrome://version >> Profile Path

## References

- Documentation: [Cucumber Gherkin][cucumber_gherkin]
- Documentation: [Assertions][nunit_assert]
- Documentation: [Selenium Locators][selenium_locators]
- Documentation: [Specflow][specflow]

[project_csharp]: https://github.com/enroute-university/QA101_final_project_csharp
[cucumber_gherkin]: https://cucumber.io/docs/gherkin/reference/
[nunit_assert]: https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertions.html
[selenium_locators]: https://www.selenium.dev/documentation/webdriver/elements/locators/
[specflow]: https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html
