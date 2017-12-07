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

        public static int CorruptionChecksum(string input)
        {
            var sanitize = input.Replace('\t', ' ');

            var separators = new[] { "\r\n" };
            var rows = sanitize.Split(separators, StringSplitOptions.None);

            return rows
                .Select(GetRows)
                .Select(x=> x.Last() - x.First())
                .Sum();

            IEnumerable<int> GetRows(string row)
            {
                var i = row
                    .Split(' ')
                    .Select(x => int.Parse(x))
                    .OrderBy(x=>x);

                return i;
            }
        }
    }
}
