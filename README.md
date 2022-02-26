# Selenium
 Selenium simple web framework using page object model for basic websites having say atleast five to ten pages. Please don't forget to hit the donate button below and make a kind donation if you or your organisation is benefitting from this work. You can also please star the project to keep the project active.

# Introduction 
 Selenium automated tests framework for a sample app. This repo can be used as a startup for writing C# api tests. 
 
 1. The **TestCases** folder have samples for integration api tests. The **Services** folder consists one service file for each microservice.
 2. A new **Microservice** file can be added for a new microservice with various http calls like per say GET, POST, PUT, DELETE, etc,. calls for it. 
 3. **Data** file can host the data needed for the tests using nunit data driven framework. The website URL can be added here as well.
 4. **Constants** file consists of the constants like the server name, protocol, api keys and other constants.
 5. **Pages** folder consists of page objects for each page. Each page object needs to be initialized when using objects on that page.
 6. **Tests** folder consists of nunit test cases for a test flow like navigating each page on a website.
 7. **Models** folder consists of models for responses which can be generated on jsontocsharp
 8. Parallel/ multi thread test execution possible using nunit for faster test runs. Set *LevelOfParallelism* to say ideally 4 and play with parallel scope in **NUnitSettings** file.

# Getting Started
 Git clone the repo and open the solution file on your VS. I am not sure about other IDEs. 
1.	Installation process - Cloning the repo and opening the solution in MS Visual Studio 2021 using .NET 6.0 should be good enough. The below Nuget packages get installed as well when the solution is opened in VSTS and is documented only for showing the dependencies here.
2.	Software dependencies - trying almost 0 (none) but **NUnit**, **Selenium.Webdriver**, **Selenium.Support**, , **Selenium.Webdriver.ChromeDriver**
3.	Latest releases - main branch
4.	API references - NA

# Build and Test
In VS* Tests--> Test Explorer shows the tests and can used to run or debug the tests.

#### Donations
Please feel free to donate as this work is made possible with donations like yours. It involves years of efforts with money, time and efforts spent to obtain the college degree and experience gained to write quality software. PM for customizations and implementations.

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=ZKRHDCLG22EJA)

Most of all. Enjoy Coding :+1: