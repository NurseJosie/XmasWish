using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Utils
{
    public class XmasWish
    {
        public void XmasWishList()
        {
            using (var checker = new Database())
            {
                int rowsPeople =checker.People.Count();
                int rowsGifts = checker.Gifts.Count();
                int rowsAlreadyGifted = checker.AlreadyGifted.Count();

                if(rowsPeople == 0 && rowsGifts == 0 && rowsAlreadyGifted == 0)
                {
                    using (var db = new Database())
                    {
                        db.People.Add(new Models.Person
                        {
                           PersonName = "Kalle Anka",
                           RelationshipToMe = "Farbror"
                           // FK
                           //FK
                         });
                        db.SaveChanges();

                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName =  "Halsduk i Kashmir",
                            Store = "Åhléns",
                            Price = 799
                            // given to person-id
                            // FK already gifted: lista alla person ID(namn) som den är given till
                        });
                        db.SaveChanges();

                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName = "Röd handväska",
                            Store = "H&M",
                            Price = 399
                            // given to person-id
                            // FK already gifted: lista alla person ID(namn) som den är given till
                        });
                        db.SaveChanges();

                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName = "Trisslott",
                            Store = "Pressbyrån",
                            Price = 30
                            // given to person-id
                            // FK already gifted: lista alla person ID(namn) som den är given till
                        });
                        db.SaveChanges();

                        db.AlreadyGifted.Add(new Models.AlreadyGifted
                        {
                            //FK      // lista alla klappar som personen fått, HUR? checka av att den är given och kom ihåg!
                        });
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
