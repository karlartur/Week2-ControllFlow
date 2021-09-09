using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Sisesta oma sünniaasta:");
           
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            Console.WriteLine($"Sa oled {Age} aastat vana.");

            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }

            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor.");

                Console.WriteLine("Et juhiluba saada, sa pead olema vähemalt 18.");
            }
            
            Console.WriteLine("Kena päeva.");

        }
    }
}
