using System.Runtime.CompilerServices;

namespace _2_Canvas_Oppgave_Loops;
class Program
{
    static void Main(string[] args)
    {
        // int number = 5;
        // string text = "Random words";
        // double dubble = 6.9;
        // char x = 'S';

        int[] myNum = {1, 2, 3, 4, 5};
        for (int i = 0; i <= 5; i = i + 1) 
        {
            Console.WriteLine(i);
        }

        string[] myString = {"First", "Second", "Third", "Fourth", "Fifth"};
        foreach (string i in myString) 
        {
            Console.WriteLine(i);
        }

        List<string> myList = new List<string>();
        myList.Add("Alpha");
        myList.Add("Beta");
        myList.Add("Delta");
        myList.Add("Phi");
        myList.Add("Omega");
        foreach (string i in myList) 
        {
            Console.WriteLine(i);
        }

    }
}
