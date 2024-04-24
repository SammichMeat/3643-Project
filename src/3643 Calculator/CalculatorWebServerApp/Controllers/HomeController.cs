using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using _3643_Calculator;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private CalculatorEngine _calc = new CalculatorEngine();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public ActionResult Add(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        
        return Json(new { result = inputA+ " + " + inputB + " = "+ _calc.Add() });
    }
    [HttpPost]
    public ActionResult Subtract(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        
        return Json(new { result = inputA+ " - " + inputB + " = "+ _calc.Subtract() });
    }
    public ActionResult Multiply(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        return Json(new { result = inputA+ " * " + inputB + " = "+ _calc.Multiply() });
    }
    public ActionResult Divide(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
            return Json(new { result = inputA+ " / " + inputB + " = "+ _calc.Divide() });
    }
    public ActionResult Equals(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        if (_calc.Equals() == 1)
        {
            return Json(new { result = inputA+ " == " + inputB + " = True"});
        }
        return Json(new { result = inputA+ " == " + inputB + " = False"});
    }
    public ActionResult Power(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        return Json(new { result = inputA+ " ^ " + inputB + " = "+ _calc.RaiseToPower() });
    }
    public ActionResult Log(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        return Json(new { result = inputA+ " log " + inputB + " = "+ _calc.Logarithm() });
    }
    public ActionResult Root(string inputA, string inputB)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        _calc.SetDoubleB(Convert.ToDouble(inputB));
        
        return Json(new { result = inputA+ " root " + inputB + " = "+ _calc.Root() });
    }
    public ActionResult Factorial(string inputA)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        
        return Json(new { result = inputA+ " ! = "+ _calc.Factorial() });
    }
    public ActionResult Sine(string inputA)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        
        return Json(new { result = " sin "+ inputA +" = "+_calc.Sine() });
    }
    public ActionResult Cosine(string inputA)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        
        return Json(new { result = " cos "+ inputA +" = "+_calc.Cosine() });
    }
    public ActionResult Tangent(string inputA)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        
        return Json(new { result = " tan "+ inputA +" = "+_calc.Tangent() });
    }
    public ActionResult Reciprocal(string inputA)
    {
        _calc.SetDoubleA(Convert.ToDouble(inputA));
        
        return Json(new { result = " 1 / "+ inputA +" = "+_calc.Reciprocal() });
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}