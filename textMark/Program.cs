using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Displaying the text mark, corresponding to a appropriate numerical mark: ");
        Console.WriteLine("Enter your numerical mark: ");
        string input=Console.ReadLine();
        int numMark;
       

        if (int.TryParse(input, out numMark))
        {
            if (numMark >=9)
            {
                Console.Write("The corresponding text mark is - Sobresaliente!");
            }
            else if (numMark ==7 || numMark==8)
            {
                Console.Write("The corresponding text mark is - Notable!");
            }
            else if(numMark == 6)
            {
                Console.Write("The corresponding text mark is - Bien!");
            }
            else if (numMark == 5) 
            {
                Console.Write("The corresponding text mark is - Aprobado!");
            }
            else if (numMark >=0 && numMark<=4)
            {
                Console.Write("The corresponding text mark is - Suspenso!");
            }
        }
        else
        {
            Console.WriteLine("Enter the correct numerical mark ");
        }
    }
}