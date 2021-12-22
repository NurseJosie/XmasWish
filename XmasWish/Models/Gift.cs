using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        public string GiftName { get; set; }
        public string Store { get; set; }
        public double Price { get; set; }

        // given till .... true/false hur till vem?????????
        //public List<AlreadyGifted> AlreadyGifted { get; set; }  // FK?
    }
}
