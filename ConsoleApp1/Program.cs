using System;
// Szymon Michoń

namespace ConsoleApp1
{
    class Student
    {
        //domyślnie private
        public
            int Age;
    }
    class Program
    {

        static void Main(string[] args)
        {

            Student student = new Student();
            student.Age = 16;
            Console.Write("Wpisz tekst co się ma wyświetlić: ");
            Console.Beep(); //robi beep, dźwięk systemu
            string txt = Console.ReadLine();
            Console.WriteLine(txt);
            Console.ReadKey();// zatrzymuje konsole w celu zobaczenia wyniku

            string[] seasons = new[] { "Wiosna", "Lato", "Jesień", "Zima" }; //tak ładnie
            int[] number = new int[10]; //tak ładnie
            // string[] seasons = new[4] { "Wiosna", "Lato", "Jesień", "Zima" }; tak nie ładnie, tak nie robimy
            if (student.Age > 18)
            {
                Console.WriteLine("can drink");
            }
            else
            {
                Console.WriteLine(" go home");
            }
            Console.WriteLine(student.Age > 18 ? "Can drink." : "Go home."); // rewelacyjna skrócona wersja ifa

            ////////RÓŻNICA FOR A FOREACH////////////////
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Wypisanie for");
            }
            
            foreach (string season in seasons){
                Console.WriteLine("Wypisanie tablicy przez foreach");
                Console.WriteLine(season);
            }
            //

        }
    }
}
