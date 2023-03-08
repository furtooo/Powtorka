using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Komputer
        {
            public string marka { get; set; }
            public string model { get; set; }
        }
        class PC : Komputer
        {
            public string rObudowy { get; set; }
        }

        class Laptop : Komputer
        {
            //proste styl c# \/
            public double dPrzekatnej { get; set; }
            //trudniejsze styl js \/
            public string kObudowy;
            public string getKObudowy() { return kObudowy; }
            public void setKObudowy(string kObudowy) { this.kObudowy = kObudowy; }
        }

        class Osoba
        {
            //jeszcze inny sposob \/
            string imie;
            public string Imie { get => imie; set => imie = value; }
        }

        //dziedziczenie
        class Opiekun : Osoba { }
        class Klient : Osoba { }
        class Serwisant : Osoba { }

        class Zlecenie
        {
            Komputer komputer;
            Klient klient;
            Opiekun opiekun;

            public Zlecenie(Komputer komputer, Klient klient, Opiekun opiekun)
            { 
                this.komputer = komputer;
                this.klient = klient;
                this.opiekun = opiekun;
            }
        }


        static void Main(string[] args)
        {
            //proste takie
            /* Laptop lap = new Laptop();
            lap.marka = Console.ReadLine();
            lap.model = Console.ReadLine();
            lap.dPrzekatnej = double.Parse(Console.ReadLine());
            lap.setKObudowy(Console.ReadLine());

            Console.WriteLine(lap.marka + " " + lap.model + " " + lap.dPrzekatnej + " " + lap.getKObudowy());
            Console.ReadKey(); */

            //trudniejsze i kreatywane

            Console.WriteLine("Co masz do naprawy? 1 - komp, 2 - lap");

            int wybor = int.Parse(Console.ReadLine());
            switch(wybor)
            {
                case 1:
                    {
                        PC pc = new PC();
                        pc.marka = Console.ReadLine();
                        pc.model = Console.ReadLine();
                        pc.rObudowy = Console.ReadLine();
                        break;
                    }

                case 2:
                    {
                        Laptop lap = new Laptop();
                        lap.marka = Console.ReadLine();
                        lap.model = Console.ReadLine();
                        lap.dPrzekatnej = double.Parse(Console.ReadLine());
                        lap.setKObudowy(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
