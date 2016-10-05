using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace hello_world
{
    public class CountLetters
    {
     
        public char Letter(string name)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int max = 0;
            foreach (char c in name)
            {
                int i;
                dict.TryGetValue(c, out i);
                i++;
                if (i > max)
                {
                    max = i;
                }
                dict[c] = i;
            }
            foreach (KeyValuePair<char, int> chars in dict)
            {if (chars.Value == max)
                {
                    return (chars.Key);
                }
             
            }
            //Console.ReadLine();
            return char.MinValue;
        }
      
            }
}