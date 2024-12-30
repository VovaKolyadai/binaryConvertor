using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConvertor
{
    public static class BinaryConvertor
    {
        public static double Convert(string code)
        {
            double result = 0;
            int index = 0;
            for (int i = code.Length - 1; i >= 0; i--)
            {
                if (!(code[i].Equals('0') || code[i].Equals('1'))) throw new ArgumentException("code have to contain 1 and 0");
                result += int.Parse(code[i].ToString()) * Math.Pow(2, index);
                index++;
            }
            return result;
        }
    }
}
