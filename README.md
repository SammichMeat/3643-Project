# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator

This repository contains the work done as part of the Spring 2024 semester project at Kennesaw State University for the class SWE 3643 Software Testing and Quality Assurance. The aim of the project was to apply the knowledge gained over the course of the semester by creating testable code, as well as testing that code. The repository gives detailed instructions of how to set up the [Environment](#environment) for application use, as well as how to perform Unit and End-To-End tests on the code using NUnit and Playwright.

# Table of Contents

- [Environment](#environment)
- [Executing the Web Application](#executing-the-web-application)
- [Executing Unit Tests](#executing-unit-tests)
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
- [Executing End-To-End Tests](#executing-end-to-end-tests)
- [Final Video Presentation](#final-video-presentation)

# Team Members

Adam Tucker : [LinkedIn](https://www.linkedin.com/in/atucker84/)

# Architecture

![UML](https://www.plantuml.com/plantuml/svg/VL9DQnin4BtlhnYIYqDmUY-bP9Euf0T_K6zIA0KZhoPhqLbfaKQsGyb_hzJrncATzHviYNblD6_UktKiBFkQCa5aThNQArrbMIFAFw92kBWNL7eIR2nCTAKqmk9G-WGpKQCBIBo0IrBLXjVaCVkRGVXA4ix1aNqWjyNuNKCkvUWANiW81gKRppbSfzUx13ld3TfYP-ODMg7b57bZf1lTtDnSPGbigNIlPRz7G5I47xM9eBSiUpih_aahXW8TEzWg0RDuxzI_OjnWq3-aFe9RRi1qArW5LT_Ym66mXL6QdmLvTAiVoDvgj_JrwEg0Vb1R9N5rYiwr_8NMT9o9jSO6LYAxUxhJ6fN2cG77uwydrS7T_CGrBD5kqKBUDFqmTDkO6edaZlTdXRlaUcyqMqE4riNHqdkSvWZl5uvz-vM-W65lvRWmu_2NMBiWyRgpGKZFN_ZONrcOy9Ew2zS9u4cj2iM41Uuvs2IaozsnsdfrmWZfw8TZvkirMhTwKAu90xh9li6IKSuzDxuDmq2pDZp3sUawpWpdxIjfZFhTPaO745fL2lgkmzFl_F-iAJedgg5HxWc5lVFCHhTdTo37xHJc0L-49rwoO1ozPnK6rnsjJgt_38z5iOXmYax-rl28GX8w1tVMx1pQ68IIZ9TmcPYwKHAXLBOaR2rE2D2TuCkPvqBVMzJIr_GF)

The application is using C# on the backend, HTML on the frontend, and NUnit and Playwright for unit tests and end-to-end tests respectively. For the web server app, the Model View Controller architectural pattern was utilized to provide functionality for the website.
Development was split between two machines, one running Windows 10 and one running Windows 11, both being 64-bit versions. The application is running .NET Core 8.0 so it should run on operating systems compatible with it, but it was not tested on those platforms so aspects of this document such as environment setup may be innaccurate for other operating systems.

# Environment
To prepare your environment to execute this application:
1. [Download .NET Core 8.0](https://dotnet.microsoft.com/en-us/download).
2. [Install PowerShell](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.4)

To configure playwright, note the file location of the CalculatorEndToEndTests project folder and type the following into the command line or terminal of your IDE:
``` 
cd (file location of CalculatorEndToEndTests)

dotnet add package Microsoft.Playwright.NUnit

dotnet build

pwsh bin/Debug/net8.0/playwright.ps1 install
```

After installing .NET Core 8.0 and configuring playwright, you will be able to [Execute the Web Application](#executing-the-web-application), [Execute Unit Tests](#executing-unit-tests), and [Execute End-To-End Tests](#executing-end-to-end-tests)

# Executing the Web Application
This section outlines how to get the web application running on your system for use as well as running [End-To-End Tests](#executing-end-to-end-tests):
1. Clone or download this repo and note its location on your system.
2. Open the command line and set your current working directory to the file location of the CalculatorWebServerApp Folder: `cd ...\src\3643Calculator\CalculatorWebServerApp`
3. Execute the CalculatorWebServerApp project by using: `dotnet run`
4. A message similar to this should be shown:
```
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5116
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\Downloads\3643-Project\src\3643Calculator\CalculatorWebServerApp
```
5. To connect, type http://localhost:5116 in your browser and begin use of the application.

# Executing Unit Tests
This section outlines the process for executing the Unit tests for the CalculatorEngine project. Executing unit tests does not require the web app to be running.
1. Open the command line and set your current working directory to the file location of the CalculatorEngineUnitTests Folder: `cd ...\src\3643Calculator\CalculatorEngineUnitTests`
2. Execute the test project by using: `dotnet test`
3. Test will run and something akin to the following will be displayed:
```
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:    20, Skipped:     0, Total:    20, Duration: 12 ms - CalculatorEngineUnitTests.dll (net8.0)
```

# Reviewing Unit Test Coverage

Below is the coverage achieved of the CalculatorEngine class from CalculatorEngineUnitTests:

<img src="https://github.com/SammichMeat/3643-Project/blob/main/CalcEngineCoverage.PNG">

Full 100% coverage of all calculator logic and paths was achieved in 20 unit tests. Window shown is JetBrains Rider and its coverage visual.

# Executing End-To-End Tests
The end-to-end tests test various aspects of the code such as the page title and error displays.
1. The [web application](#executing-the-web-application) must first be running.
2. In a new command line window, navigate to the CalculatorEndToEndTests folder: `cd ...\src\3643Calculator\CalculatorEndToEndTests`
3. Execute the tests by using: `dotnet test`
4. Test will run and text similar to the following will be displayed:
```
Test run for ...\src\3643Calculator\CalculatorEndToEndTests\bin\Debug\net8.0\CalculatorEndToEndTests.dll (.NETCoreApp,Version=v8.0)
Microsoft (R) Test Execution Command Line Tool Version 17.9.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 1 s - CalculatorEndToEndTests.dll (net8.0)
```

# Final Video Presentation

[Presentation Video](https://vimeo.com/939227664?share=copy)

