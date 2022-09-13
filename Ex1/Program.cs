using System;
class program
{
    static void Main(string[]args)
    {
        double BtsStation, Cost;

        Console.WriteLine("Please input number of station:");
        BtsStation = double.Parse(Console.ReadLine());

        if(BtsStation == 1)
        {
            Cost = 16;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 2)
        {
            Cost = 23;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 3)
        {
            Cost = 26;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 4)
        {
            Cost = 30;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 5)
        {
            Cost = 33;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 6)
        {
            Cost = 37;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation == 7)
        {
            Cost = 40;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation >=8 && BtsStation <= 15)
        {
            Cost = 44;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else if (BtsStation > 15)
        {
            Cost = 59;
            Console.Write("Cost(THB):{0}",Cost);
        }
        else
        {
            Console.Write("Error|go back to sleep");
        }
    }
}
