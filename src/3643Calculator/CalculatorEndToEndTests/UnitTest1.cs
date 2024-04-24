using System.Linq.Expressions;

namespace CalculatorEndToEndTests;


[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task CalculatorUi_TitleText_ReadsAsCalculator()
    {
        //preq-E2E-TEST-5
        
        await Page.GotoAsync("http://localhost:5116");

        await Expect(Page).ToHaveTitleAsync(new Regex("Calculator"));

       
    }
    [Test]
    public async Task CalculatorUi_AddTwoFloatingPointNumbers_DisplaysExpectedOutputValue()
    {
        //preq-E2E-TEST-6
        
        await Page.GotoAsync("http://localhost:5116");

        await Page.GetByTestId("inputA").FillAsync("10");
        await Page.GetByTestId("inputB").FillAsync("5");

        await Page.GetByTestId("addButton").ClickAsync();

        await Expect(Page.GetByTestId("jumbotronText")).ToContainTextAsync("10 + 5 = 15");
    }
    [Test]
    public async Task CalculatorUi_DivideFloatingPointValueAndZero_DisplaysNotANumberError()
    {
        //preq-E2E-TEST-7
        
        await Page.GotoAsync("http://localhost:5116");

        await Page.GetByTestId("inputA").FillAsync("10");
        await Page.GetByTestId("inputB").FillAsync("0");

        await Page.GetByTestId("divideButton").ClickAsync();

        await Expect(Page.GetByTestId("jumbotronText")).ToContainTextAsync("10 / 0 = Not a Number");
    }
    [Test]
    public async Task CalculatorUi_NonNumericalInput_DisplaysErrorMessage()
    {
        //preq-E2E-TEST-8
        
        await Page.GotoAsync("http://localhost:5116");

        await Page.GetByTestId("inputA").FillAsync("10");
        await Page.GetByTestId("inputB").FillAsync("fifteen");

        await Page.GetByTestId("addButton").ClickAsync();  
        
        await Expect(Page.GetByTestId("jumbotronText")).ToContainTextAsync("Invalid Input, Numbers Only");
    }
    [Test]
    public async Task CalculatorUi_ClearButton_ClearsDisplayTextToDefaultState()
    {
        //preq-E2E-TEST-9
        //note: preq-E2E-TEST-9 notes that text should be "Enter a value(s) below and select an operation.",
        //  yet in other places in requirements its shown that it should be "Enter value(s) below and select an operation.". It is set to test as the latter.
        
        await Page.GotoAsync("http://localhost:5116");

        await Page.GetByTestId("inputA").FillAsync("10");
        await Page.GetByTestId("inputB").FillAsync("fifteen");

        await Page.GetByTestId("addButton").ClickAsync();  
        await Page.GetByTestId("clearButton").ClickAsync(); 
        
        await Expect(Page.GetByTestId("jumbotronText")).ToContainTextAsync("Enter value(s) below and select an operation.");
    }
}