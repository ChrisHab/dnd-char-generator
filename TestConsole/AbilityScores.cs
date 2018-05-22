using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class AbilityScores
    {
        public List<int> roll()
        {
            //Dictionary<int, int> ACsToMods = new Dictionary<int, int>() {
            //    {4,-3},{5,-3},{6,-2},{7,-2},{8,-1},{9,-1}, {10,0}, {11,0}, {12,1}, {13,1},{14,2}, {15,2}, {16,3}, {17,3}, {18,4}, {19,4}, {20,5}
            //};
            List<int> ASs = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int AS = 0;
                int min = 6;
                for (int k = 0; k < 4; k++)
                {
                    int a = rnd.Next(1, 6);
                    if (a < min) { min = a; }
                    AS += a;
                }
                AS -= min;
                ASs.Add(AS);
            }

            return ASs;

        }

    }
}
