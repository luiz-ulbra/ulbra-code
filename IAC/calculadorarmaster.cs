using System;

class calculadoramaster
{
	public static void Main ()
	{
		float N1 = 0;
		float N2 = 0;
		float Result = 0;
		string Oper ="";
		
		Console.WriteLine("selecione a opcao + || - || * || /");
		Oper = Console.ReadLine();
		
		Console.WriteLine("digite um numero:");
		N1 = float.Parse(Console.ReadLine());
		
		Console.WriteLine("digite mais um numero");
		N2 = float.Parse(Console.ReadLine());
		
		if(Oper == "+")
		{
			Result = N1 + N2;
		}
		else if(Oper == "-")
		{
			Result = N1 - N2;
		}	
		else if (Oper == "*")
		{
			Result = N1 * N2;
		}
		else if (Oper == "/")
		{	
			Result = N1 / N2;
		}
		else
			Console.WriteLine("ERRO COM OPERADOR");

		Console.WriteLine(" O resultado é: " + 	Result);
		Console.ReadLine();
	}
}
