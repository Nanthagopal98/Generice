using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
    public static void Main(string[] args)
    {
        var log = NLog.LogManager.GetCurrentClassLogger();
        log.Info("Find Maximum started");
        findMaximumValue<int> findMaximumValue;
        new findMaximumValue<int>(10, 20, 30, 40).display();
        new findMaximumValue<float>(10.5F, 20.5F, 30.5F, 95.95F).display();
        new findMaximumValue<string>("Apple", "Banana", "Orange", "Kivi").display();
    }
    
    }
