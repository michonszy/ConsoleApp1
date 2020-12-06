using System;

/// <summary>
/// /////////////PLIK JEST OGÓLNYM OMÓWIENIEM SKŁADNI C# JAKO WPROWADZENIA DLA ZNAJĄCYCH INNE JĘZYKI
/// Wszystko w jednym pliku żeby nie szukać, żeby nie zgubić, żeby mieć
/// Pisał: Szymon Michoń
/// Użytek: osobisty lecz rozpowszechniany dlatego jak na słaby kod przystało, dużo komentarzy bo inaczej trudno się połapać
/// </summary>
namespace ConsoleApp1
{
    class Student
    {
        //domyślnie private
    }
    //DZIEDZICZENIE, to rozszerzenie funkcjonalności klasy pozwalające na współdzielenie kodu w klasach, jest zawsze publiczne
    class Studentka : Student
    {
        public string imie;
        int StudentkaAge;
        string StudentkaKierunek;
        char StudentkaGrupa;

        Studentka()
        {
            StudentkaAge = Age;
            StudentkaKierunek = Kierunek;
            //StudentkaGrupa = Grupa a tak NIE WOLMO bo jest prywatne

        }
    }
    //Metoda wirtualna to metoda którą można nadpisać w klasie pochodnej poprzez słowo kluczowe override
    //Polimorfizm to wywołanie metod z klasy pochodnej gdy obiekt przypisany jest do zmiennej klasy bazowej

    //Klasy i metody abstrakcyjne
    //////Nie można utworzyć instancji klasy abstrakcyjnej
    //Motoda abstrakcyjna nie posiada ciała, tylko nagłowek metody
    //Słowo kluczowe do stworzenia to abstract
    //Interfejsy
    //Wskazują jakie metody zawiera klasa je implementujaca
    //Nie posiadają implementacji metod i pól
    class Program
    {
        enum miesiace { styczen, luty, marzec, kwiecen, maj, czerwiec, lipiec, sierpien, wrzesien, pazdziernik, listopad, grudzien }


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
            Console.WriteLine("Podstawowa tablica ma długość: " + number.Length);
            Array.Resize(ref number, 20); //korzystajmy z gotowych rozwiązań, tak jak w JAVA, w C++ takich nie ma :(
            Console.WriteLine("A po zmianie: " + number.Length);

            if (student.Age > 18)
            {
                Console.WriteLine("can drink");
            }
            else
            {
                Console.WriteLine(" go home");
            }
            Console.WriteLine(student.Age > 18 ? "Can drink." : "Go home."); // rewelacyjna skrócona wersja ifa

            {
            }
            
                Console.WriteLine("Wypisanie tablicy przez foreach");
                Console.WriteLine(season);
            }

        }
    }
}
    

