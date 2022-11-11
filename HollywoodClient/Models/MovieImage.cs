using System.ComponentModel.DataAnnotations;

namespace HollywoodClient.Models
{
    public class MovieImage
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Picture { get; set; }
    }
}
