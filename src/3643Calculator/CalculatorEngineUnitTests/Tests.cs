using CalculatorEngineNet8;
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
    public void Add_TwoFloatingPointValues_ReturnsSum()
    {
        //preq-UNIT-TEST-2

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(5);
        //act
        var a = _calc.Add();
        //assert
        Assert.That(a, Is.EqualTo(15));
    }

    [Test]
    public void Subtract_TwoFloatingPointValues_ReturnsDifference()
    {
        //preq-UNIT-TEST-3

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(5);
        //act
        var a = _calc.Subtract();
        //assert
        Assert.That(a, Is.EqualTo(5));
    }

    [Test]
    public void Multiply_TwoFloatingPointValues_ReturnsProduct()
    {
        //preq-UNIT-TEST-4

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(5);
        //act
        var a = _calc.Multiply();
        //assert
        Assert.That(a, Is.EqualTo(50));
    }

    [Test]
    public void Divide_TwoFloatingPointValues_ReturnsQuotient()
    {
        //preq-UNIT-TEST-5

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(5);
        //act
        var a = _calc.Divide();
        //assert
        Assert.That(a, Is.EqualTo(2));
    }

    [Test]
    public void Divide_FloatingPointValueAndZero_ReturnsError()
    {
        //preq-UNIT-TEST-6

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(0);

        //act-assert
        Assert.Throws<DivideByZeroException>(() => _calc.Divide());
    }

    [Test]
    public void Equals_TwoDifferentFloatingPointValues_ReturnsZero()
    {
        //preq-UNIT-TEST-7    (a)
        //split into two tests to test functionality when true and false

        //arrange
        _calc.SetDoubleA(0.33333333);
        _calc.SetDoubleB(0.33333334);

        //act
        var a = _calc.Equals();

        //assert
        Assert.That(a, Is.EqualTo(0));
    }

    [Test]
    public void Equals_TwoEqualFloatingPointValues_ReturnsOne()
    {
        //preq-UNIT-TEST-7    (b)

        //arrange
        _calc.SetDoubleA(0.333333332);
        _calc.SetDoubleB(0.333333331);

        //act
        var a = _calc.Equals();

        //assert
        Assert.That(a, Is.EqualTo(1));
    }

    [Test]
    public void RaiseToPower_TwoFloatingPointValues_ReturnsNumberRaised()
    {
        //preq-UNIT-TEST-8

        //arrange
        _calc.SetDoubleA(2);
        _calc.SetDoubleB(3);

        //act
        var a = _calc.RaiseToPower();

        //assert
        Assert.That(a, Is.EqualTo(8));
    }

    [Test]
    public void Logarithm_TwoFloatingPointValues_ReturnsLog()
    {
        //preq-UNIT-TEST-9

        //arrange
        _calc.SetDoubleA(8);
        _calc.SetDoubleB(2);

        //act
        var a = _calc.Logarithm();

        //assert
        Assert.That(a, Is.EqualTo(3));
    }

    [Test]
    public void Logarithm_ZeroOrNegativeAndFloatingPointNumber_ReturnsError()
    {
        //preq-UNIT-TEST-10

        //arrange
        _calc.SetDoubleA(0);
        _calc.SetDoubleB(2);

        //act-assert
        Assert.Throws<ArithmeticException>(() => _calc.Logarithm());
    }

    [Test]
    public void Logarithm_FloatingPointNumberAndZero_ReturnsError()
    {
        //preq-UNIT-TEST-11

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(0);

        //act-assert
        Assert.Throws<ArithmeticException>(() => _calc.Logarithm());
    }

    [Test]
    public void Root_TwoFloatingPointNumbers_ReturnsNthRoot()
    {
        //preq-UNIT-TEST-12

        //arrange
        _calc.SetDoubleA(8);
        _calc.SetDoubleB(3);

        //act
        var a = _calc.Root();

        //assert
        Assert.That(a, Is.EqualTo(2));
    }

    [Test]
    public void Root_FloatingPointNumberAndZero_ReturnsError()
    {
        //preq-UNIT-TEST-13

        //arrange
        _calc.SetDoubleA(10);
        _calc.SetDoubleB(0);

        //act-assert
        Assert.Throws<ArithmeticException>(() => _calc.Root());
    }

    [Test]
    public void Factorial_OneFloatingPointNumber_ReturnsNumberFactorial()
    {
        //preq-UNIT-TEST-14

        //arrange
        _calc.SetDoubleA(5);

        //act
        var a = _calc.Factorial();

        //assert
        Assert.That(a, Is.EqualTo(120));
    }

    [Test]
    public void Factorial_FactorialConventionNumberIsZero_ReturnsOne()
    {
        //preq-UNIT-TEST-15

        //arrange
        _calc.SetDoubleA(0);

        //act
        var a = _calc.Factorial();

        //assert
        Assert.That(a, Is.EqualTo(1));
    }

    [Test]
    public void Sine_FloatingPointAngleInDegrees_ReturnsSineOfAngle()
    {
        //preq-UNIT-TEST-16

        //arrange
        _calc.SetDoubleA(1);

        //act
        var a = _calc.Sine();

        //assert
        Assert.That(a, Is.EqualTo(0.0174524));
    }

    [Test]
    public void Cosine_FloatingPointAngleInDegrees_ReturnsCosineOfAngle()
    {
        //preq-UNIT-TEST-17

        //arrange
        _calc.SetDoubleA(60);

        //act
        var a = _calc.Cosine();

        //assert
        Assert.That(a, Is.EqualTo(.5));
    }

    [Test]
    public void Tangent_FloatingPointAngleInDegrees_ReturnsTangentOfAngle()
    {
        //preq-UNIT-TEST-18

        //arrange
        _calc.SetDoubleA(1);

        //act
        var a = _calc.Tangent();

        //assert
        Assert.That(a, Is.EqualTo(.0174551));
    }

    [Test]
    public void Reciprocal_FloatingPointNumberConvertedToInt_ReturnsReciprocal()
    {
        //preq-UNIT-TEST-19
        
        //arrange
        _calc.SetDoubleA(8);
        
        //act
        var a = _calc.Reciprocal();
        
        //assert
        Assert.That(a,Is.EqualTo(.125));
    }
    [Test]
    public void Reciprocal_Zero_ReturnsError()
    {
        //preq-UNIT-TEST-20

        //arrange
        _calc.SetDoubleA(0);

        //act-assert
        Assert.Throws<DivideByZeroException>(() => _calc.Reciprocal());
    }
}