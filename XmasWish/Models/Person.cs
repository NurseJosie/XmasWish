using System.ComponentModel.DataAnnotations;

namespace XmasWish.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [MaxLength(50)]  // sparar minne
        public string FirstName { get; set; }
        [MaxLength(50)]  // sparar minne
        public string LastName { get; set; }
        [MaxLength(100)]
        public string RelationToUser { get; set; }
        public List<Gift> Gifts { get; set; } 
    }
}
