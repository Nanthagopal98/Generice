using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class generics<T>
    {
    public  T[] arraylist;
    public generics(T[] arraylist)
    {
        this.arraylist = arraylist;
    }
        public void toPrint()
        {
            foreach(var element in arraylist)
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
 
}



