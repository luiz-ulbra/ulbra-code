using System;

class media
{
	public static void Main()
	{
		float Nota1 = 0;
		float Nota2 = 0;
		float media = 0;
		
		Console.WriteLine("DIGITE A SUA PRIMEIRA NOTA!");
		Nota1 = float.Parse(Console.ReadLine());
		
		Console.WriteLine("DIGITE A SUA SEGUNDA NOTA!");
		Nota2 = float.Parse(Console.ReadLine());
		
		media =(Nota1+(Nota2*2))/3;
		Console.Write("Sua media é " + media);
		if (media>6)
		{	
			Console.WriteLine(" VOCE ESTA ACIMA DA MEDIA!");
		}	
			else
			Console.WriteLine(" VOCE NAO ESTA ACIMA DA MEDIA!");
		
		Console.ReadLine();
	}
}