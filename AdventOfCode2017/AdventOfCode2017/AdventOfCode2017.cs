using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    public class AdventOfCode2017
    {
        public static string InverseCaptcha(string input)
        {
            var test = input.Select(x => int.Parse(x.ToString())).ToList();
            test.Add(test.First());

            var zipped = test.Zip(test.Skip(1), (prev, curr) => new { prev, curr });

            return zipped
                .Where(a => a.prev == a.curr)
                .Select(x => x.curr)
                .Sum()
                .ToString();
        }
    }
}
