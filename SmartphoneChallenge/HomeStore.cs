using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.SmartphoneChallenge
{
    public class HomeStore
    {
        public void DownloadWhatsapp()
        {
            Console.WriteLine("Nokia:");
            Smartphone nokia = new Nokia(number: "11990005827", model: "Cell 1", imei: "111", memory: 128);
            nokia.StartPhone();
            nokia.InstallApp("Whatsapp");
            Console.WriteLine("\n");
        }

        public void DownloadTelegram()
        {
            Console.WriteLine("Iphone:");
            Smartphone iphone = new Iphone(number: "11990005827", model: "Cell 1", imei: "253", memory: 64);
            iphone.GetCall();
            iphone.InstallApp("Telegram");
        }
    }
}