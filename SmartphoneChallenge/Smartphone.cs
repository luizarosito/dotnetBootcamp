namespace dotnetBootcamp.SmartphoneChallenge
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }    
        public int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void StartPhone()
        {
            Console.WriteLine("Starting...");
        }

        public void GetCall()
        {
            Console.WriteLine("Getting call...");
        }

        public abstract void InstallApp(string appName);
    }
}