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
        findMaximumValue.findMax(30, 20, 10);
        
        }
    }
