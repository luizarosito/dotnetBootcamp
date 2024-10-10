using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.SmartphoneChallenge
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = Memory;
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine("Downloading the app " + appName + "...");
        }

    }
}