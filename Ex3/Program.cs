using System;
class program
{
    static void Main(string[]args)
    {
        int DisasterLv;
        Console.WriteLine("Input Disaster Level 0-7:");
        DisasterLv = int.Parse(Console.ReadLine());

       switch (DisasterLv)
       {
        case 1 :
        case 3 :
        case 5 :
        case 7 :

        Console.WriteLine("yellow");
        break;
       }

       switch (DisasterLv)
       {
        case 2:
        case 3:
        case 6:
        case 7:

        Console.WriteLine("Orange");
        break;
       }

       switch (DisasterLv)
       {
        case 4:
        case 5:
        case 6:
        case 7:

        Console.WriteLine("Red");
        break;
       }
    }
}
