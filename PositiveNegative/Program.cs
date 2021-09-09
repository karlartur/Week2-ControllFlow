using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit -10 kuni 10
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "positive"
            //kui number on negatiivne, końsool kuvab "negative"
            //kuinumber on 0, siis konsool kuvab"null"

            Console.WriteLine("Sisesta number -10 kuni 10:");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            if (UserNumber > 0)
            {
                Console.WriteLine("Positive.");
            }

            else if (UserNumber < 0)
            {
                Console.WriteLine("Negative.");
            }
            
            else 
            {
                Console.WriteLine("Null.");
            }

        }
    }
}
