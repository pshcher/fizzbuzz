using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        //comment 12
        public static string GetValue(int input)
        {
            return input.ToString();
        }

        public static int FirstUnique2(string str)
        {
            int found = -1;

            if (str == null)
                return found;

            Dictionary<char, int> pairs = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (pairs.ContainsKey(c))
                    pairs[c]++;
                else
                    pairs.Add(c, 1);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (pairs[str[i]] == 1)
                    return i;
            }

            return found;
        }

        public static int getUniqueCount2(string str)
        {
            int count = 0;
            if (string.IsNullOrEmpty(str))
                return count;

            //HashSet ignores duplicates, no exception thrown
            HashSet<char> chars = new HashSet<char>(str);

            return chars.Count;
        }

        public static int FirstUnique(string str)
        {
            int index = -1;

            if (str == null)
                return index;

            // value is positive for index, negative if multiple occurences found
            Dictionary<char, int> chars = new Dictionary<char, int>();
            int i = 0;
            foreach( var c in str)
            {
                if (chars.ContainsKey(c))
                    chars[c] = -1;
                else
                    chars.Add(c, i);

                i++;
            }

            foreach( var m in chars)
            {
                if (m.Value < 0)
                    continue;

                if (index == -1)
                    index = m.Value;
                else if ( m.Value < index  )
                    index = m.Value;
            }

            return index;
        }

        public static int getUniqueCount(string str)
        {
            int count = 0;
            if (string.IsNullOrEmpty(str))
                return count;

            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach( var c in str)
            {
                if (chars.ContainsKey(c))
                    chars[c]++;
                else
                {
                    chars.Add(c, 1);
                    count++;
                }
            }

            return count;
        }
    }
}
