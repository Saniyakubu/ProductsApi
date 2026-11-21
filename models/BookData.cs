namespace ProductsApi.models
{
    //{ id = 1, title = "Atomic Habits", author = "James Clear", price = 15000d, genre = "Self Help", isAvailable = true },
    public class BookData
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Genre { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }

    }
}
