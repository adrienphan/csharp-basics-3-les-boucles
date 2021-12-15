using System;
					
public class Program
{
	public static void Main()
	{
		int result = 0;
      string answer = "o";
      while (answer != "n"){
         Console.WriteLine("veuillez ajouter un nombre à " + result);
         result += Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Le resultat est " + result + ". Souhaitez vous continuer ?(o/n)");
         answer = Console.ReadLine();
      }
	}
}