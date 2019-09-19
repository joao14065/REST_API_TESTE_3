using REST_API_TESTE_3.Model.Base;
using System;

namespace REST_API_TESTE_3.Model
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
