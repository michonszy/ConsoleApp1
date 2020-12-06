using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// /////////////PLIK JEST OGÓLNYM OMÓWIENIEM SKŁADNI C# JAKO WPROWADZENIA DLA ZNAJĄCYCH INNE JĘZYKI
/// Wszystko w jednym pliku żeby nie szukać, żeby nie zgubić, żeby mieć
/// Pisał: Szymon Michoń
/// Użytek: osobisty lecz rozpowszechniany dlatego jak na słaby kod przystało, dużo komentarzy bo inaczej trudno się połapać
/// Już nie taki fajny bo github zepsuł dużo godzin pracy :( naprawianie w trakcie
/// </summary>
namespace ConsoleApp1
{
    class Student
    {
        public int Age;

        protected string Kierunek;
        private char grupa = 'D';

        public void UczelniaNiestatyczna() { }
        public static void UczelniaStatyczna() { }
        public static string UczelniaString;

        //domyślnie private
        //Modyfikatory dostępu: public, private, internal, protected (dostęp wewn klasy oraz dziedziczących), protected internal (wewn klasy, dziedziczących lub jednego assembly)
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
            //metody statyczne i niestatyczne
            student.UczelniaNiestatyczna();
            Student.UczelniaStatyczna(); //dostęp do uczelni statycznej tylko bezpośrednio, nie dla instancji klasy
           

            Console.Write("Wpisz tekst co się ma wyświetlić: ");
            Console.Beep(); //robi beep, dźwięk systemu
            string txt = Console.ReadLine();
            Console.WriteLine(txt);
            Console.ReadKey();// zatrzymuje konsole w celu zobaczenia wyniku
            string[] seasons = new[] { "Wiosna", "Lato", "Jesień", "Zima" }; //tak ładnie
            int[] number = new int[10]; //tak ładnie
            Console.WriteLine("Rozmiar tablicy przed zmianami " + number.Length);
            Array.Resize(ref number, 20); //przykład gotowej metody do zmiany tablicy tak jak w JAVA, boli C++ co?? xD
            Console.Write("Rozmiar tablicy po ArrayResize " + number.Length);

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
            //róźnica w użyciu for i foreach
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Wypisanie przez for po raz " + i);
            }
           
            foreach (string season in seasons) { 
                Console.WriteLine("Wypisanie tablicy przez foreach");
                Console.Write(season);
            }
            //Korzystajmy z gotowych klas skoro już są
            DateTime data = new DateTime(2020,11,11);
            Console.WriteLine("7 dni od podanej daty bedzie" + data.AddDays(7));
            Console.WriteLine("Obecnie mamy rok " + data.Year);

            //enum zapisany poza main
            miesiace miesiac;
            int numer_miesiaca;
            Console.Write("Podaj numer 1-12 a dowiesz się jaki to miesiąc: ");
            numer_miesiaca = Console.Read();
            switch (numer_miesiaca) {
                case 1: miesiac = miesiace.styczen; break;
                case 2: miesiac = miesiace.luty; break;
                case 3: miesiac = miesiace.marzec; break;
                case 4: miesiac = miesiace.kwiecen; break;
                case 5: miesiac = miesiace.maj; break;
                case 6: miesiac = miesiace.czerwiec; break;
                case 7: miesiac = miesiace.lipiec; break;
                case 8: miesiac = miesiace.sierpien; break;
                case 9: miesiac = miesiace.wrzesien; break;
                case 10: miesiac = miesiace.pazdziernik; break;
                case 11: miesiac = miesiace.listopad; break;
                case 12: miesiac = miesiace.grudzien; break;
                default:
                    throw new ArgumentOutOfRangeException("Mówiłem 1-12, nieładnie");
                    //rzucanie wyjatkami opisane poniżej
            }
            Console.WriteLine(miesiac);

            //PRACA Z PLIKAMI
            FileStream plik = new FileStream("plik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //tutaj kompilator sam powinien podpowiedzieć dodanie nowej biblioteki do obsługi plików
            //Możliwe FileMode
            //Append tworzy lub otwiera plik i przechodzi na jego koniec, wymaga obiektu z parametrem FileAccess.Write
            //Create tworzy plik, w razie gdy istnieje usuwa jego zawartość i zastępuje nową
            //CreateNew tworzy plik, w razie gdy istnieje generuje wyjątek
            //Open otwiera plik do odczytu, gdy nie istnieje generuje wyjątek
            //OpenOrCreate otwiera plik, jeżeli ten nie istnieje tworzy nowy
            //Truncate otwiera plik i czyści jego zawartość

            //Możliwe FileAccess
            //Read
            //Write
            //ReadWrite

            StreamWriter zapis = new StreamWriter(plik); //tutaj przekazanie argumentu w nawiasach
            zapis.WriteLine("Dodany do pliku napis");
            zapis.Close(); //niby nie trzeba ale TRZEBA za każdym razem KONIECZNIE zamykamy kazdy plik który otwarliśmy i zrywamy nawiązane połączenie

            StreamReader odczyt = new StreamReader(plik);
            string text;
            text = odczyt.ReadLine();
            odczyt.Close();
            Console.WriteLine(text);

            //Wyjątki co by się nie wykraczyło
            //Wyjątki możemy łapac przez try catch
            //Na pokaz weźmiemy oklepany jak Najman w KSW przykład dzielenia przez 0

            try //coś co powinno działać ale nie musi
            {
                string x = Console.ReadLine();
                int xx = int.Parse(x); //konwersja typów, easy huh? Nie to co c++
                string y = Console.ReadLine();
                int yy = int.Parse(y);
                Console.WriteLine(xx / yy);
            }
            catch (DivideByZeroException DivEx) //łapanie za wyjątki
            {
                Console.WriteLine(DivEx.Message);
                Console.WriteLine("Czyżbyś probował dzielić przez 0?");
            }
            //Przykładowe wyjątki
            //ArithmeticException 
            //DivideByZeroException
            //ArgumentNullException
            //InvalidAsynchronousStateException wątek który chcesz użyć już nie istnieje
            //ArgumentOutOfRangeException 
            //ObjectNotFoundException
            //EntityException

            //Blok finally i uzycie
            int A = 10;
            try
            {
                string B = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Nie zmieniłeś zmiennej, ojoj nieładnie");
            }
            finally
            {
                Console.WriteLine(A);
            }

            //Rzucanie wyjątków
            //W przypadku np, wyjścia za zakres switcha możemy zrobić to co w powyższym kodzie default throw

            //checked i unchecked
            int max = int.MaxValue; //reprezentuje największą możliwą wartość inta
            unchecked
            {
                Console.WriteLine(max);
                Console.WriteLine(++max);
                Console.WriteLine(max + 64000000);
            }
            ////////////////TYPY GENERYCZNE/////////////
            //Kolekcje - zbiór obiektów, podobne do tablic, w stosunku do tablic mogą mieć: dynamiczny rozmiar, wiele rodzajów pojemników, zbiór metod do operacji na danych
            //ArrayList - możemy przechowywać różne typy obiektów, występują pronlemy z pakowaniem i rozpakowaniem, nie zalecane
            //Kolekcje generyczne - wykorzystują typy generyczne, brak pakowania i rozpakowania, bezpieczeństwo typu
            //typ - klasa która zawiera parametr typu
            //Kolekcje generyczne
            //List <T>
            //Stack<T>
            //Queue<T>
            //Dictionary<TKey, TValue>
            //SortedSet<T>
            List<int> lista = new List<int>(); //konieczna biblioteka using System.Collections.Generic , system powinien to podpowiedzieć
            lista.Add(5);
            lista.Add(1);
            lista.Add(3);
            //Metody List<t>
            //Add(t)
            //Clear()
            //Contains(t)
            //IndexOf(t)
            //Insert(Int32,t)
            //Remove(t), RemoveAt(Int32)
            //Reverse()
            //Sort()
            //Tworzenie metod:
            // typ zwracany nazwa <T> (T argument) {}
            static void zamien<T>(T arg1, T arg2)
            {
                T obj = arg1;
                arg1 = arg2;
                arg2 = obj;
            }
            //ref i out
            //Obiekt przekazywany jest przez referencję a nie wartość
            //Powodują odwołanie do oryginalnego obiektu
            // ref wymaga aby zmienna była juz zainicjalizowana
            // out dopuszcza każdą zmienna


            //ograniczenie typu
            // typ zwracany nazwa <T> (T argument): [ograniczenie]{}
            //np.struct,class,new(), nazwaklasybazowej, nazwabazowegointerfejsu
            //klasy generyczne
            //class nazwa<T> {}
        }
    }
}


    

