using System;
using System.Reflection;

namespace dotnetBootcamp.SmartphoneChallenge
{ 
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public override void InstallApp(string appName) 
        {
            Console.WriteLine("Downloading the app " + appName + "...");
        }
    }
}
