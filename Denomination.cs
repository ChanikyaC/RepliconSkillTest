using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		int withdrawAmount = Convert.ToInt32(Console.ReadLine());
		int [] validDenominations = new int[5]  {5, 10, 50, 100, 500};
		
		if (withdrawAmount % 5 != 0)
		{
			Console.Write("Invalid Amount");
			return;
		}
		
		try
		{
			foreach (int denomination in validDenominations.OrderByDescending(e => e))
			{
				int count = withdrawAmount / denomination;
				withdrawAmount = withdrawAmount % denomination;
				Console.WriteLine("{0} * {1}", denomination, count);
			}
		}
		
		catch (Exception e)
		{
			Console.WriteLine (e.Message);
		}
		Console.Read();
	}
}
