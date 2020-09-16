using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Services
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required,StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Location { get; set; }
        public CusineType Cusine { get; set; }
    }
}
