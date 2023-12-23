using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.data
{
    public class Hotel
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Address { get; set; }

        public double Rateing { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
