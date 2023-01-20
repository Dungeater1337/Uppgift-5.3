using System;

class Program
{
    static void Main(string[] args)
    {

        string[] frågor = { "Vad är det högsta berget i världen?", "Vad är det största landet i världen?", "Vad är den längsta floden i världen?", "Vilken planet är närmast solen?" };
        string[] svar = { "Mount Everest", "Ryssland", "Nilen", "Mercury" };

        
        Console.WriteLine("Välj en fråga genom att ange ett tal från 1 till 4:");
        int userChoice = int.Parse(Console.ReadLine()) - 1;

       
        Console.WriteLine("Fråga: " + frågor[userChoice]);

     
        Console.WriteLine("Svara på frågan:");
        string userAnswer = Console.ReadLine();

   
        if (userAnswer.ToLower() == svar[userChoice].ToLower())
        {
            Console.WriteLine("Rätt svar!");
        }
        else
        {
            Console.WriteLine("Fel svar. Det rätta svaret är: " + svar[userChoice]);
        }
    }
}
