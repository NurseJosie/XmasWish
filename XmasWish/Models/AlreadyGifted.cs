using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Models
{
    public class AlreadyGifted
    {
        [Key]
        public int Id { get; set; }
        //public List<Person> Persons { get; set; } // FK
    }
}
