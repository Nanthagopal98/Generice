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
        findMaximumValue findMaximumValue = new findMaximumValue();
        findMaximumValue.findMax<int>(30, 20, 10);
        findMaximumValue.findMax<float>(10.5F, 20.5F, 30.5F);
        findMaximumValue.findMax<string>("Apple", "Banana", "Orange");
    }
    }
