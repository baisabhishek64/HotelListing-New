using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Hotel
{
    public class GetHotelDto
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Address { get; set; }

        public double Rateing { get; set; }
        public int CountryId { get; set; }
    }
}
