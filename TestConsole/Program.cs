using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Es muss Datenbank sowie Unit-Tests da sein
            Console.WriteLine("Hello World!");
            Console.WriteLine(addTwoNumbers(2, 4));

            Character cronos = new Character(19, 15, 17, 10, 12, 11, "Roy Greenhilt", "Christoph");
            Console.WriteLine(returnModifiers(cronos.Str));
            Console.WriteLine(cronos.CarryingCapacity);
            Console.WriteLine(cronos.Prof);
            Looks l1 = new Looks();
            Console.WriteLine(l1.HowDoILook("gnome"));
        }

        public static int addTwoNumbers(int one, int two)
        {
            return one + two;
        }

        public static int toHit(Character character)
        {
            return returnModifiers(character.Str) + character.Prof;
        }

        public static int returnModifiers(int stat)
        {
            if (stat == 1)
                return -5;
            else if (stat == 2 || stat == 3)
                return -4;
            else if (stat == 4 || stat == 5)
                return -3;
            else if (stat == 6 || stat == 7)
                return -2;
            else if (stat == 8 || stat == 9)
                return -1;
            else if (stat == 10 || stat == 11)
                return 0;
            else if (stat == 12 || stat == 13)
                return 1;
            else if (stat == 14 || stat == 15)
                return 2;
            else if (stat == 16 || stat == 17)
                return 3;
            else if (stat == 18 || stat == 19)
                return 4;
            else if (stat == 20 || stat == 21)
                return 5;
            else if (stat == 22 || stat == 23)
                return 6;
            else if (stat == 24 || stat == 25)
                return 7;
            else if (stat == 26 || stat == 27)
                return 8;
            else if (stat == 28 || stat == 29)
                return 9;
            else if (stat == 30)
                return 10;

            return 0;
        }
    }
}
