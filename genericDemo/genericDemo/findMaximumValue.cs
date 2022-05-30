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
        return input[input.Length - 1];
    }
    public void display()
    {
        Console.WriteLine("Maximum value is : "+findMax());
    }
}



