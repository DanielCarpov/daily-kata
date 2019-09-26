using System;

namespace DailyKata
{
    public class HaystackNeedleKata
    {
        public static string FindNeedle(object[] haystack)
        {
            if (haystack == null)
            {
                throw new ArgumentNullException(nameof(haystack));
            }

            int i = 0;
            int index = -1;

            Type t1;
            Type t2 = typeof(string);

            foreach (var el in haystack)
            {
                if (el != null)
                {
                    t1 = el.GetType();
                    if (t1 == t2 && el == "needle")
                    {
                        index = i;
                        break;
                    }
                }
                i++;
            }

            if (index != -1)
            {
                Console.WriteLine("found the needle at position " + index.ToString());
                return "found the needle at position " + index.ToString();
            }

            return "needle not found";

            //throw new NotImplementedException();
        }
    }
}
