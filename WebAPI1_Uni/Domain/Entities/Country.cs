namespace WebAPI1_Uni.Domain.Entities
{
    public class Country
    {

        public Country()
        {
            City = new List<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }


        public List<City> City { get; set; }


    }
}
