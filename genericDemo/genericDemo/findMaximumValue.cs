using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class findMaximumValue<T>
{
    public T[] input;
    public findMaximumValue(params T[] input) 
    {
        this.input = input;
    }
    public T findMax()
    {
        Array.Sort(input);
        Console.WriteLine(input[input.Length - 1]);
        return input[input.Length - 1];
    }
}



