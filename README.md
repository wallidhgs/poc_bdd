# QA 101 Final Project BDD

BDD version of the project [QA101_final_project_csharp][project_csharp]

## Dependencies

```sh
dotnet restore
```

## Chrome profile

* Windows 7, 8.1, and 10 \
    `C:\Users\<username>\AppData\Local\Google\Chrome\User Data\Default`
* Mac OS X El Capitan \
    `Users/<username>/Library/Application Support/Google/Chrome/Default`
* Linux \
    `/home/<username>/.config/google-chrome/default`

>Replace `<user>` with your username \
>chrome://version >> Profile Path

## References

* Documentation: [Cucumber Gherkin][cucumber_gherkin]
* Documentation: [Assertions][nunit_assert]
* Documentation: [Selenium Locators][selenium_locators]
* Documentation: [Specflow][specflow]

[project_csharp]: https://github.com/enroute-university/QA101_final_project_csharp

[cucumber_gherkin]: https://cucumber.io/docs/gherkin/reference/
[nunit_assert]: https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertions.html
[selenium_locators]: https://www.selenium.dev/documentation/webdriver/elements/locators/
[specflow]: https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html
