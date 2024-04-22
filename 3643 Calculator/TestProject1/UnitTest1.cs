using _3643_Calculator.Properties;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace TestProject1;
using NUnit.Framework;
public class Tests
{
    private CalculatorEngine calc;
    [SetUp]
    public void Setup()
    {
        calc = new CalculatorEngine();
    }

    [Test]
    public void CalculatorEngine_DivideMethod_ThrowsErrorIfDivideByZero()
    {
        //arrange
        calc.SetDoubleA(10);
        calc.SetDoubleB(0);
        //act
        //assert
    }
}