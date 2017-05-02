using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADES
{
    public class Test
    {
        public void Boom()
        {
            int allAges = 0;
            int[] ages = { 2, 21, 40, 72, 100 };
            foreach (int value in ages)
            {
                allAges += value;
            }
            Console.WriteLine(allAges);

        }
    }
}
