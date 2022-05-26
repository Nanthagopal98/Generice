using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class generics
    {
        public static void toPrint(int[] intArrayList)
        {
            foreach(int element in intArrayList)
            {
                Console.WriteLine(element);
            }
        }
        public static void toPrint(double[] doubleArrayList)
        {
            foreach(double element in doubleArrayList)
            {
                Console.WriteLine(element);
            }
        }
        public static void toPrint(char[] charArrayList)
        {
            foreach(char element in charArrayList)
            {
                Console.WriteLine(element);
            }
        }
    static void Main(string[] args)
    {
        int[] intArrayList = { 1,2,3,4,5};
        double[] doubleArrayList = { 1.1,2.2,3.3,4.4,5.5};
        char[] charArrayList = { 'A', 'B', 'C', 'D', 'E' };

        generics.toPrint(intArrayList);
        generics.toPrint(doubleArrayList);
        generics.toPrint(charArrayList);
    }
}



