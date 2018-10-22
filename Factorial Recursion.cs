using System;

public class RecursiveFactorial
{
	public static void Main()
	{	
		int number=Convert.ToInt32(Console.ReadLine());

		if (number < 0)
		{
			Console.Write("Factorial is defined only for non-negative integer numbers");
			return;
		}
		long factorial=RecuriveMethod(number);
		Console.Write(factorial);
	}
	
	private static long RecuriveMethod(int number)
        {          
            if (number == 0)
				return 1;
            return number * RecuriveMethod(number - 1);
        }
}