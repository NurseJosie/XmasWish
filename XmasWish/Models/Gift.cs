using System.ComponentModel.DataAnnotations;

namespace XmasWish.Models
{
    public class Gift
    {
        [Key]
        public int GiftId { get; set; }
        [MaxLength(50)] // sparar minne
        public string GiftName { get; set; }
        [MaxLength(50)] // sparar minne
        public string Store { get; set; }
        public int Price { get; set; }
        public List<Person> People { get; set; }
    }
}
