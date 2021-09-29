using System;

namespace Amazon_Discount_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(discount("The price with 25% off is $.99"));
        }

        static string discount(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '$')
                {
                    string temp = "";
                    i++;
                    while (i<s.Length &&((s[i] >= '0' && s[i] <= '9') || s[i] == '.'))
                    {
                        temp += s[i];
                        i++;
                    }
                    decimal P = Convert.ToDecimal(temp);
                    P = P - (P / 4);
                    res += P.ToString("C2");
                }
                else
                    res += s[i];
            }
            return res;
        }
    }
}
