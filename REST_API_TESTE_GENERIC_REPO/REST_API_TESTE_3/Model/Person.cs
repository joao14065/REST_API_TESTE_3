using REST_API_TESTE_3.Model.Base;

namespace REST_API_TESTE_3.Model
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }


    }
}
