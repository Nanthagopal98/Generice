using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class findMaximumValue
{
    public int findMax(int firstValue, int secondValue, int thirdValue)
    {
        int maxValue;
        if (firstValue > secondValue && firstValue > thirdValue)
        {
            maxValue = firstValue;
        }
        else if (secondValue > firstValue && secondValue > thirdValue)
        {
            maxValue = secondValue;
        }
        else
        {
            maxValue = thirdValue;
        }
        Console.WriteLine(maxValue);
        return maxValue;

    }

}



