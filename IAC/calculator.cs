using System;

class calculator
{
	public static void Main ()
	
	{ int NumeroUm;
	
		Console.WriteLine("digite um numero:");
		NumeroUm = int.Parse(Console.ReadLine());
		Console.WriteLine("O usuario digitou o numero " 
							+ NumeroUm);
		Console.ReadLine();
	}
}