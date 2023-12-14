namespace WebAPI1_Uni.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Regions_Number { get; set; }

        public int People { get; set; }

        
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
