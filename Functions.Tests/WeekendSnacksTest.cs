using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Functions.Tests;

[TestClass]
[TestSubject(typeof(WeekendSnacks))]
public class WeekendSnacksTest
{

    [TestMethod]
    public void TestEvenNumber_GiveNumber_ReturnsTrue() {
        var output = new WeekendSnacks();
        bool result = output.isEven(10);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestEvenNumber_GiveOddNumber_ReturnsFalse() {
        var output = new WeekendSnacks();
        bool result = output.isEven(9);
        Assert.IsFalse(result);
        
    }

    [TestMethod]
    public void TestPrimeNumber_GiveNumber_ReturnsTrue() {
        var output = new WeekendSnacks();
        bool result = output.isPrimeNumber(7);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestToSubtractNumbers_ReturnsPositiveNumbersOnly() {
        var output = new WeekendSnacks();
        int result = output.subtract(7, 3);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void TestToDivideNumbers_ReturnsPositiveNumbersOnly() {
        var output = new WeekendSnacks();
        float result = output.divide(12,3);
        Assert.AreEqual(4, result);
        
    }

    [TestMethod]
    public void TestFactorsOfInteger_ReturnsTheFactorsOfAllNumbers() {
        var output = new WeekendSnacks();
        int result = output.factorOf(10);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void TestToCalculateSquare_ReturnsTrue()
    {
        var output = new WeekendSnacks();
        Assert.IsTrue( output.isSquare(25));
    }

    [TestMethod]
    public void TestToCalculatePalindrome_ReturnsFalse()
    {
        var output = new WeekendSnacks();
        bool result = output.isPalindrome(12121);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestToCalculateFtorial_ReturnsTheResultAsLong()
    {
        var output = new WeekendSnacks();
        long result = output.factorialOf(5);
        Assert.AreEqual(120, result);
    }

    [TestMethod]
    public void TestToCalculateSquareOfaNumber_ReturnsTheResultAsLong()
    {
        var output = new WeekendSnacks();
        long result = output.squareOf(5);
        Assert.AreEqual(25, result);
    }
    
}