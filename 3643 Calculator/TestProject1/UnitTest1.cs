using _3643_Calculator.Properties;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
namespace TestProject1;

public class Tests
{
    private CalculatorEngine _calc;
    [SetUp]
    public void Setup()
    {
        _calc = new CalculatorEngine();
    }

    [Test]
    public void CalculatorEngine_DivideMethod_ThrowsErrorIfDivideByZero()
    {
        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(5);
        //act
        var a = _calc.Divide();
        //assert
        Assert.That(a,Is.EqualTo(2));
    }
}