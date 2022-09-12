using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PokerAnalyzer.Code.Functions
{
    public static class ListExtensions
    {
        public static IList<T> Shuffle<T>(this IList<T> original)
        {
            var list = new List<T>(original);
            var provider = RandomNumberGenerator.Create();
            var n = list.Count;
            while (n > 1)
            {
                var box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                var k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
