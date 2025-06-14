namespace UnitTestingDemo.core;

public class Calculator
{
   public static int Multiply(int a, int b)
   {
      return a * b;
   }
   public static int Divide(int a, int b)
   {
      if (b == 0)
    {
        throw new ArgumentException("Cannot divide by zero.");
    }
      return a / b;
   }

   public static bool IsOdd(int a)
   {
      if (a % 2 != 0)
      { return true; }
      else
      { return false; }
   }
}
