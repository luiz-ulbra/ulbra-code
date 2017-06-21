using System;

class numerocs
{
		public static void Main()
		{
			float number;
			
			Console.WriteLine("DIGITE O NUMERO: ");
			number = float.parse(Console.ReadLine());
			
		if ((number>=100) && (number<=1000));
		{
		
			Console.WriteLine(" O SEU NUMERO ESTA ENTRE O 100 E O 1000 !!" , number);
		}
		
		else
			Console.WriteLine(" O SEU NUMERO NAO ESTA ENTRE O NUMERO 100 E O 1000 !! " ,number);
		

		
		Console.ReadLine();
		}
}		