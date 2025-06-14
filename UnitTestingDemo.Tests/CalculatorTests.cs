using Xunit;
using UnitTestingDemo.core;
namespace UnitTestingDemo.Tests;

public class CalculatorTests
{
  [Fact]
  public void Multiply_TowpositiveNumbers_ReturnsCorrectProduct()
  {
    int a = 3;
    int b = 2;
    int result = Calculator.Multiply(a, b);
    Assert.Equal(6, result);
  }

  [Fact]
  public void Multiply_TownegativeNumbers_ReturnsPositivenumber()
  {
    int a = -5;
    int b = -5;
    int result = Calculator.Multiply(a, b);
    Assert.Equal(25, result);
  }

  [Fact]
  public void Multiply_NegativeNumberPositiveNumber_ReturnsNegativeNumber()
  {
    int a = -7;
    int b = 5;
    int result = Calculator.Multiply(a, b);
    Assert.Equal(-35, result);
  }
  
  [Fact]
  public void Divide_TowpositiveNumbers_ReturnsPositivenumber()
  {
    int a = 6;
    int b = 2;
    int result = Calculator.Divide(a, b);
    Assert.Equal(3, result);
  }

  [Fact]
  public void Divide_NegativeNumberPositiveNumber_ReturnsNegativeNumber()
  {
    int a = 8;
    int b = -2;
    int result = Calculator.Divide(a, b);
    Assert.Equal(-4, result);
  }

  [Fact]
  public void Divide_ByZero_ThrowError()
  {
    int a = 4;
    int b = 0;
    Calculator.Divide(a, b);
    
  }

  [Fact]
  public void IsOdd_PositiveEvenNumber()
  {
    int a = 2;
    bool result = Calculator.IsOdd(a);
    Assert.False(result);
  }

  [Fact]
  public void IsOdd_NegativeEvenNumber()
  {
    int a = -4;
    bool result = Calculator.IsOdd(a);
    Assert.False(result);
  }

  [Fact]
  public void IsOdd_PositiveOddNumber()
  {
    int a = 7;
    bool result = Calculator.IsOdd(a);
    Assert.True(result);
  }
  
}




