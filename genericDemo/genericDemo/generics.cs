using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class generics
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        /*public static void toPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        public static void toPrint(char[] inputArray)
        {
            foreach(char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }*/
    static void Main(string[] args)
    {
        int[] intArrayList = { 1,2,3,4,5};
        double[] doubleArrayList = { 1.1,2.2,3.3,4.4,5.5};
        char[] charArrayList = { 'A', 'B', 'C', 'D', 'E' };

        generics.toPrint<int>(intArrayList);
        generics.toPrint<double>(doubleArrayList);
        generics.toPrint<char>(charArrayList);
    }
}



