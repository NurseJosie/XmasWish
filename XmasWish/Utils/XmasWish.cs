using XmasWish.Models;
using Microsoft.EntityFrameworkCore;

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

                if(rowsGifts == 0 && rowsPeople == 0)
                {
                    using (var db = new Database())
                    {
                        db.People.Add(new Models.Person
                        {
                            FirstName = "Kalle",
                            LastName = "Anka",
                            RelationToUser = "Farbror"
                        });
                        db.Gifts.Add(new Models.Gift
                        {
                            GiftName = "Blanket",
                            Store = "NK",
                            Price = 1000
                        });
                        db.SaveChanges();

                        var kalle = db.People.Include("Gifts").FirstOrDefault(p => p.FirstName == "Kalle");
                        if (kalle.Gifts != null) kalle.Gifts = new List<Gift>();

                        var gift = db.Gifts.FirstOrDefault(g => g.GiftName == "Blanket");
                        if (gift != null)   kalle.Gifts.Add(gift);

                        db.Update(kalle);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
