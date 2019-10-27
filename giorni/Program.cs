using System;

namespace giorni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quale giorno vuoi selezionare? 1/2/3/4/5/6/7");
            string giorno = Console.ReadLine();
            switch(giorno)
            {
                case "1":
                    Console.WriteLine("domenica");
                    break;
                case "2":
                    Console.WriteLine("lunedi");
                    break;
                case "3":
                    Console.WriteLine("martedi");
                    break;
                case "4":
                    Console.WriteLine("mercoledi");
                    break;
                case "5":
                    Console.WriteLine("giovedi");
                    break;
                case "6":
                    Console.WriteLine("venerdi");
                    break;
                case "7":
                    Console.WriteLine("sabato");
                    break;
            }
            Console.ReadLine();
        }
    }
}
