using XmasWish.Models;
using Microsoft.EntityFrameworkCore;

namespace XmasWish.Utils
{
    public class XmasWish
    {
        public void XmasWishList()
        {
            using (var checker = new Database())  // kollar om det redan finns en testperson i databasen
            {
                int rowsPeople = checker.People.Count();
                int rowsGifts = checker.Gifts.Count();

                if (rowsGifts == 0 && rowsPeople == 0)
                {
                    using (var db = new Database()) // lägger till en testperson i databasen
                    {
                        db.People.Add(new Models.Person
                        {
                            FirstName = "Kalle",
                            LastName = "Anka",
                            RelationToUser = "Farbror"
                        });
                        db.Gifts.Add(new Models.Gift  // lägger till julklappsförslag i databasen
                        {
                            GiftName = "Ullpläd",
                            Store = "NK",
                            Price = 999
                        });
                        db.SaveChanges();

                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName = "Skål",
                            Store = "Åhléns",
                            Price = 299
                        });
                        db.SaveChanges();

                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName = "Choklad",
                            Store = "ICA",
                            Price = 70
                        });
                        db.SaveChanges();

                        var kalle = db.People.Include("Gifts").FirstOrDefault(p => p.FirstName == "Kalle"); // parar ihop person och gift, enligt https://drive.google.com/file/d/1G5PWFFTJ4UdppYvGKGuA6m5ke7NSMZga/view
                        if (kalle.Gifts != null) kalle.Gifts = new List<Gift>();

                        var gift = db.Gifts.FirstOrDefault(g => g.GiftName == "Ullpläd");
                        if (gift != null) kalle.Gifts.Add(gift);

                        db.Update(kalle);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
