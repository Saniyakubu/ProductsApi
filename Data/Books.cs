using ProductsApi.models;

namespace ProductsApi.Data
{
    public class Books
    {
        public static List<BookData> bookList = new() 
        {
            new() { Id = 1, Title = "Atomic Habits", Author = "James Clear", Price = 15000d, Genre = "Self Help", IsAvailable = true },
            new()  { Id = 2, Title = "Clean Code", Author = "Robert Martin", Price = 22000d, Genre = "Technology", IsAvailable = true },
            new() { Id = 3, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Price = 12000d, Genre = "Finance", IsAvailable = false },
            new() { Id = 4, Title = "The Alchemist", Author = "Paulo Coelho", Price = 10000d, Genre = "Fiction", IsAvailable = true },
            new() { Id = 5, Title = "Deep Work", Author = "Cal Newport", Price = 18000d, Genre = "Productivity", IsAvailable = false },
            new() { Id = 6, Title = "The Psychology of Money", Author = "Morgan Housel", Price = 16000d, Genre = "Finance", IsAvailable = true },
            new() { Id = 7, Title = "Clean Architecture", Author = "Robert Martin", Price = 25000d, Genre = "Technology", IsAvailable = true },
            new() { Id = 8, Title = "Think and Grow Rich", Author = "Napoleon Hill", Price = 14000d, Genre = "Finance", IsAvailable = false }
        };
    }
}
