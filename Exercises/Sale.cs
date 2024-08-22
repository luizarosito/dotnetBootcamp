using Newtonsoft.Json;

namespace dotnetBootcamp.Exercises
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime dateSale)
        {
            Id = id;
            Product = product;
            Price = price;
            DateSale = dateSale;
        }
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime DateSale { get; set; }

        [JsonProperty("Chargeback_Price")]
        public decimal Chargeback  { get; set; }
        public DateTime DateCancellation { get; set; }

        public List<Sale> AddSale()
        {
            DateTime dateNow = DateTime.Now;
            List<Sale> saleList = new List<Sale>();

            Sale s1 = new Sale(1, "Supplies office", 67.50m, dateNow);
            Sale s2 = new Sale(2, "Software license", 150.00m, dateNow);

            saleList.Add(s1);
            saleList.Add(s2);

            string serialize = JsonConvert.SerializeObject(saleList, Formatting.Indented);

            try 
            {
                File.WriteAllText("Exercises/Files/sales.json", serialize);
                Console.WriteLine("--- Sales mades ---");
                Console.WriteLine(serialize);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Generic exception. {ex.Message}");
            }
            return saleList;
            
        }

        public List<Sale> GetCancelattion() 
        {
            string fileText = File.ReadAllText("Exercises/Files/CanceledSales.json");
            List<Sale> listCanceled = JsonConvert.DeserializeObject<List<Sale>>(fileText);

            Console.WriteLine("--- Sales cancels ---");

            foreach(Sale sale in listCanceled)
            {
                Console.WriteLine($"Id: {sale.Id}, Product: {sale.Product}, " +
                                $"Chargeback: {sale.Chargeback}, Date cancellation: {sale.DateCancellation.ToString("dd/MM/yyyy HH:mm")}");
            }
            return listCanceled;
        }
    }
}