using System;

public class IterativeProgram
{
	public static void Main()
	{	
		int number=Convert.ToInt32(Console.ReadLine());
		int factorial=number;
		if (number < 0)
		{
			Console.Write("Factorial is defined only for non-negative integer numbers");
			return;
		}
		
		if (number ==  0)
		{
			Console.Write("1");
			return;
		}
		
		for(int i = number - 1 ; i > 0 ; i--)
		{
			factorial = factorial * i;
		}
		Console.Write(factorial);
	}
}