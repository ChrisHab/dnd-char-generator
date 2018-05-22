using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Looks
    {
        List<string> haircolour = new List<string> { "blond", "light brown", "brown", "dark brown", "black", "red" };
        List<string> eyecolour = new List<string> { "blue", "green", "brown", "grey", "black" };
        List<string> hairlength = new List<string> { "short", "medium", "long", "very long" };

        public string HowDoILook(string race)
        {
            Random rnd = new Random();

            int rndhair = rnd.Next(0, haircolour.Count);
            string hair = haircolour[rndhair];

            int rndhairlngth = rnd.Next(0, hairlength.Count);
            string hairlngth = hairlength[rndhairlngth];

            int rndeyes = rnd.Next(0, eyecolour.Count);
            string eyes = eyecolour[rndeyes];

            double size;
            int weight;
            double hmod;
            int wmod;
            double tempwmod;


            switch (race)
            {
                case "dwarf":
                    hmod = rnd.Next(1, 4) * 0.1 + rnd.Next(1, 4) * 0.1;
                    size = 3.8 + hmod;
                    tempwmod = (rnd.Next(1, 6) + rnd.Next(1, 6)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 115 + wmod;
                    break;
                case "elf":
                    hmod = rnd.Next(1, 10) * 0.1 + rnd.Next(1, 10) * 0.1;
                    size = 4.6 + hmod;
                    tempwmod = rnd.Next(1, 4) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 90 + wmod;
                    break;
                case "human":
                    hmod = rnd.Next(1, 10) * 0.1 + rnd.Next(1, 10) * 0.1;
                    size = 4.8 + hmod;
                    tempwmod = (rnd.Next(1, 4) + rnd.Next(1, 4)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 110 + wmod;
                    break;
                case "halfling":
                    hmod = rnd.Next(1, 4) * 0.1 + rnd.Next(1, 4) * 0.1;
                    size = 2.7 + hmod;
                    tempwmod = hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 35 + wmod;
                    break;
                case "gnome":
                    hmod = rnd.Next(1, 4) * 0.1 + rnd.Next(1, 4) * 0.1;
                    size = 3.1 + hmod;
                    tempwmod = (rnd.Next(1, 4) + rnd.Next(1, 4)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 35 + wmod;
                    break;
                case "dragonborn":
                    hmod = rnd.Next(1, 8) * 0.1 + rnd.Next(1, 8) * 0.1;
                    size = 5.6 + hmod;
                    tempwmod = (rnd.Next(1, 6) + rnd.Next(1, 6)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 175 + wmod;
                    break;
                case "halfelf":
                    hmod = rnd.Next(1, 8) * 0.1 + rnd.Next(1, 8) * 0.1;
                    size = 4.9 + hmod;
                    tempwmod = (rnd.Next(1, 4) + rnd.Next(1, 4)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 110 + wmod;
                    break;
                case "halforc":
                    hmod = rnd.Next(1, 10) * 0.1 + rnd.Next(1, 10) * 0.1;
                    size = 5.0 + hmod;
                    tempwmod = (rnd.Next(1, 6) + rnd.Next(1, 6)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 140 + wmod;
                    break;
                case "Tiefling":
                    hmod = rnd.Next(1, 8) * 0.1 + rnd.Next(1, 8) * 0.1;
                    size = 4.9 + hmod;
                    tempwmod = (rnd.Next(1, 4) + rnd.Next(1, 4)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 110 + wmod;
                    break;
                default:
                    hmod = rnd.Next(1, 10) * 0.1 + rnd.Next(1, 10) * 0.1;
                    size = 4.8 + hmod;
                    tempwmod = (rnd.Next(1, 4) + rnd.Next(1, 4)) * hmod * 10;
                    wmod = (int)tempwmod;
                    weight = 110 + wmod;
                    break;
            }

            double meters = size * 0.3048;
            meters = Math.Round(meters, 2);
            double kilos = weight * 0.453592;
            kilos = Math.Round(kilos, 2);

            return "You are " + size + "ft tall (" + meters + "m), have " + hairlngth + " " + hair + " hair and " + eyes + " eyes. Your weight is " + weight + "lbs (" + kilos + "kg).";
        }
    }
}
