using System.ComponentModel.DataAnnotations;

namespace XmasWish.Models
{
    public class Gift
    {
        [Key]
        public int GiftId { get; set; }
        [MaxLength(100)]
        public string GiftName { get; set; }
        [MaxLength(100)]
        public string Store { get; set; }
        public int Price { get; set; }
        public List<Person> People { get; set; }
    }
}
