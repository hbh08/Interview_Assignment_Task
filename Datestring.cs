using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Assignment_Task
{
    internal class Datestring
    {
        static bool isValidDateMonth(string d)
        {
            bool res = true;

            string dt = "";
            string mth = "";

            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                    mth += d[i];
                else
                    dt += d[i];
            }

            int dt1 = Convert.ToInt32(dt);
            int mt = Convert.ToInt32(mth);

            if (mt > 12 || mt < 1 || dt1 < 1 || dt1 > 31)
                res = false;


            return res;
        }

        static void Main()
        {
            string s1 = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
            string v = "";

            for (int i = 0; i < s1.Length - 1; i++)
            {
                char ch = s1[i];
                if (ch >= '0' && ch <= '9')
                {
                    while (ch >= '0' && ch <= '9')
                    {
                        ch = s1[i];
                        v = v + ch;
                        i++;
                    }

                    v = v.Trim();

                    if (v.Length == 8 && isValidDateMonth(v))
                        Console.WriteLine(v + " " + v.Length);

                    v = "";
                }
            }
        }
    }
}
