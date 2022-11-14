using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodykiZarzadzaniaIT.Project
{
    public static class RandomCoinValue
    {
        public static decimal FirstCoin()
        {
            var rand = new Random();
            rand.Next(1,2);
            return rand.Next(1, 2);
        }


        public static decimal SecondCoin()
        {
            var rand = new Random();
            rand.Next(26, 29);
            return rand.Next(26, 29);
        }

        public static decimal ThirdCoin()
        {
            var rand = new Random();
            rand.Next(141, 145);
            return rand.Next(141, 145);
        }
    }
}
