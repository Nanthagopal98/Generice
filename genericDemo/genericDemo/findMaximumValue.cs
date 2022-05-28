using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class findMaximumValue
{
    public T findMax<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable<T>
    {
        int intMaxValue;
        if (firstValue.CompareTo(secondValue) >0 && firstValue.CompareTo(thirdValue) >0 ||
            firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
            firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
        {
            Console.WriteLine(firstValue);
            return firstValue;  
        }
        else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
            secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
        {
            Console.WriteLine(secondValue);
            return secondValue;   
        }
        else
        {
            Console.WriteLine(thirdValue);
            return thirdValue;
        }
        return firstValue;
    }
}



