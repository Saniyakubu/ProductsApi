namespace ProductsApi.models
{

    //"id": 1,
    //"name": "iPhone 15",
    //"brand": "Apple",
    //"price": 950000,
    //"category": "Phones"

    public class ProductData
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string brand { get; set; } = string.Empty;
        public double price { get; set; }
        public string category { get; set; } = string.Empty;

    }
}
