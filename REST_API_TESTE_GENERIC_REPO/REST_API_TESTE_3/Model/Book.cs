using System;

namespace REST_API_TESTE_3.Model
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Authos { get; set; }
        public decimal Price { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
