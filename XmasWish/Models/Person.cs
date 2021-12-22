using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string RelationshipToMe { get; set; }
        //public List<Gift> XmasWish { get; set; } // FK
        //public List<AlreadyGifted> AlreadyGifted { get; set;} // FK
    }
}
