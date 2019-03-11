using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs26Homework
{
    public class Reverse
    {
        public string ReverseString(string input)
        {
            if (input == "" || input==null)
            {
                throw new InvalidOperationException();
            }

            char[] str = input.ToCharArray();

            //Initialize left and right pointers
            int r = str.Length - 1, l = 0;

            //Traverse strings from both ends until 'l' and 'r'
            while (l < r)
            {
                //Ignore special characters
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;
                //Both str[l] and str[r] are not special
                else
                {
                    char tmp = str[l];
                    str[l] = str[r];
                    str[r] = tmp;
                    l++;
                    r--;
                }
            }
            return new String(str);
        }
    }
}
