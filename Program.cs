using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("secret_plan.txt");

        sw.WriteLine("How I'll defeat Captain Amazing");
        sw.WriteLine("Another genius secret plan by Thw Swindler");
        sw.WriteLine("I'll unleash my army of clines upon the citizens of Objectvill");

        string location = "the mall";
        for(int number = 1; number <= 5;  number++) //ternar
        {
            sw.WriteLine("Clone #{0} attacks {1}", number, location);
            location = (location == "the mall") ? "downtown" : "the mall";
        }
        sw.Close();
    }
}