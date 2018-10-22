using System;

public class RecursiveFactorial
{
	public static void Main()
	{	
		Console.WriteLine("Please enter a number to find the factorial");
		int number=Convert.ToInt32(Console.ReadLine());

		if (number < 0)
		{
			Console.Write("Factorial is defined only for non-negative integer numbers");
			return;
		}
		long factorial=RecuriveMethod(number);
		Console.Write("The Factorial of {0} is {1}" ,number, factorial);
		Console.ReadLine();
	}
	
	private static long RecuriveMethod(int number)
        {          
            if (number == 0)
				return 1;
            return number * RecuriveMethod(number - 1);
        }
}