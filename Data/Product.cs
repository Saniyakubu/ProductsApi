using ProductsApi.models;

namespace ProductsApi.Data
{
    public class ProductList
    {
        public static List<ProductData> Products = new()
        {
            new ProductData { id = 1, name = "iPhone 15", brand = "Apple", price = 950000d, category = "Phones" },
            new ProductData { id = 2, name = "Samsung S24", brand = "Samsung", price = 1100000d, category = "Phones" },
            new ProductData { id = 3, name = "Dell XPS 15", brand = "Dell", price = 1800000d, category = "Laptops" },
            new ProductData { id = 4, name = "AirPods Pro", brand = "Apple", price = 350000d, category = "Accessories" },
            new ProductData { id = 5, name = "MacBook Air M3", brand = "Apple", price = 2200000d, category = "Laptops" },
            new ProductData { id = 6, name = "PlayStation 5", brand = "Sony", price = 850000d, category = "Gaming" },
            new ProductData { id = 7, name = "Galaxy Buds 2", brand = "Samsung", price = 180000d, category = "Accessories" },
            new ProductData { id = 8, name = "iPad Air", brand = "Apple", price = 1200000d, category = "Tablets" },
            new ProductData { id = 9, name = "HP Pavilion 15", brand = "HP", price = 1350000d, category = "Laptops" },
            new ProductData { id = 10, name = "Redmi Note 13", brand = "Xiaomi", price = 320000d, category = "Phones" },
        };
    }
}
