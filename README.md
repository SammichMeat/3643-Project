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
Development was split between two machines, one running Windows 10 and one running Windows 11, both being 64-bit versions. The application is running .NET Core 8.0 so it should run on operating systems compatible with it, but it was not tested on those platforms, so aspects such as environment setup may be innaccurate.

# Environment
To prepare your environment to execute this application:
1. [Download .NET Core 8.0](https://dotnet.microsoft.com/en-us/download).
2. [Install PowerShell](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.4)
3. 



To configure playwright, note the file location of the CalculatorEndToEndTests project folder and type the following into the command line or terminal of your IDE
``` 
cd (file location of CalculatorEndToEndTests)

dotnet add package Microsoft.Playwright.NUnit

dotnet build

pwsh bin/Debug/net8.0/playwright.ps1 install
```

After installing .NET Core 8.0 and configuring playwright, you will be able to [Execute the Web Application](#executing-the-web-application), [Execute Unit Tests](#executing-unit-tests), and [Execute End-To-End Tests](#executing-end-to-end-tests)

# Executing the Web Application

Instructions for running the web application locally or deploying it to a server are provided in this section. It includes details such as configuration steps, starting the server, and accessing the application.

# Executing Unit Tests

This section covers how to run unit tests for the web application. It includes instructions for running tests, interpreting test results, and troubleshooting common issues.

# Reviewing Unit Test Coverage

Here, you'll learn how to review the unit test coverage of the web application. It includes information on measuring code coverage, identifying areas with low coverage, and improving coverage.

# Executing End-To-End Tests

Instructions for running end-to-end tests for the web application are provided in this section. It covers setup requirements, test execution, and analyzing test results.

# Final Video Presentation

This section provides details about the final video presentation of the web application project. It includes information on content, format, and delivery expectations.

