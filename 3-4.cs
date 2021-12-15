using System;
					
public class Program
{
	public static void Main()
	{
      Random randomNumber = new Random();
      int hiddenNumber = randomNumber.Next(1,51);
      int attempt;
      int attemptNumber = 1;
      Console.WriteLine("tentez de trouver mon nombre");
      attempt = Convert.ToInt32(Console.ReadLine());
		while(attempt != hiddenNumber){
         if (attempt < hiddenNumber){
            Console.WriteLine("c'est plus grand ! (tentative N°" + attemptNumber + ")");
            attempt = Convert.ToInt32(Console.ReadLine());
         }
         if (attempt > hiddenNumber){
            Console.WriteLine("c'est plus petit ! (tentative N°" + attemptNumber + ")");
            attempt = Convert.ToInt32(Console.ReadLine());
         }
         attemptNumber++;
      }
      Console.WriteLine("Bravo ! vous avez trouvé ! (tentative N°" + attemptNumber + ")");
	}
}