using Microsoft.VisualBasic;

namespace DesafioPratico01;

public class Exercicios
{
    
    public void Exercicio01()
    {
        string userName = Console.ReadLine();

        Console.WriteLine($"Olá, {userName}! Seja muito bem-vindo!");
    }

    public void Exercicio02()
    {
        string userFirstName = Console.ReadLine();
        string userLastName = Console.ReadLine();
        Console.WriteLine($"{userFirstName} {userLastName}");
    }

    public (int sum, int subtraction, int multiplication, decimal division, int average)  Exercicio03(int val1, int val2)
    {
        var sum = val1 + val2;
        var subtraction = val1 - val2;
        var multiplication =  val1 * val2;
        var division = (decimal) val1 / val2;
        var average = (val1 + val2) / 2;
        
        return (sum, subtraction, multiplication, division, average);
    }

    public void Exercicio04()
    {
        string wordFromUser = Console.ReadLine();
        
        var counter = 0;
        for(int i = 0; i < wordFromUser.Length; i++)
        {
            if (wordFromUser[i] is not ' ') counter++;
        }

        Console.WriteLine(counter);
    }


    public bool Exercicio05(string carPlate)
    {
        carPlate = carPlate.Trim().ToUpper();
        if (carPlate.Length != 7) return false;

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(carPlate[i])) return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(carPlate[i])) return false;
        }

        return true;
    }

    public void Exercicio06()
    {
        var now = DateTime.Now;
        Console.WriteLine($"Formato completo: {now}");
        Console.WriteLine($"No formato dd/mm/yyyy: {now.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Formato completo: {now.ToString("HH")}");
        Console.WriteLine($"Formato completo: {now.ToString("dd MMMM yyyy - HH:MM")}");
    }
}
