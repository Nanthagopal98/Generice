using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArrayList = { 1, 2, 3, 4, 5 };
            double[] doubleArrayList = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArrayList = { 'A', 'B', 'C', 'D', 'E' };

            generics<int> intList = new generics<int>(intArrayList);
            intList.toPrint();
            generics<double> doubleList = new generics<double>(doubleArrayList);
            doubleList.toPrint();
            generics<char> charList = new generics<char>(charArrayList);
            charList.toPrint();

        }
    }
}
