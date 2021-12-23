using XmasWish.Models;
using Microsoft.EntityFrameworkCore;

namespace XmasWish.Utils
{
    public class GiftCrud
    {
        public void CreateGift()
        {
            using (var create = new Database())
            {

                Console.WriteLine("Name of gift:");
                var createName = Console.ReadLine();

                Console.WriteLine("Where can you buy the gift?");
                var createStore = Console.ReadLine();

                Console.WriteLine("How much does the gift cost?");
                string input = Console.ReadLine();
                var createCost = 0;
                int.TryParse(input, out createCost);

                Gift gift = new Gift()
                {
                    GiftName = createName,
                    Store = createStore,
                    Price = createCost,
                };

                create.Add(gift);
                create.SaveChanges();
                Console.WriteLine("New gift added!");
                Console.ReadKey();
            }
        }
        public void ReadGifts() 
        {
            using (var read = new Database())
            {
                var list = read.Gifts.OrderByDescending(p => p.GiftId);
                foreach (var n in list)
                {
                    Console.WriteLine(" - " + n.GiftName + " - " + n.Store + " - " + n.Price);
                }
            }
            Console.ReadKey();
        }

        public void UpdateGift() 
        {
            using (var update = new Database())
            {
                Console.WriteLine("Input giftname of the gift you wish to update:");
                var inputName = Console.ReadLine();

                var u = update.Gifts.Where(f => f.GiftName == inputName).FirstOrDefault();
                if (u != null)
                {
                    Console.WriteLine("Giftname:");
                    var newName = Console.ReadLine();
                    u.GiftName = newName;

                    Console.WriteLine("Store:");
                    var newStore = Console.ReadLine();
                    u.Store = newStore;

                    Console.WriteLine("Price:");
                    string priceInput = Console.ReadLine();
                    var newPrice = 0;
                    int.TryParse(priceInput, out newPrice);
                    u.Price = newPrice;

                    update.Gifts.Update(u);
                    update.SaveChanges();
                    Console.WriteLine("Gift updated!");
                }
                else Console.WriteLine("Cannot find a gift with that giftname!");
            }
            Console.ReadKey();
        }
        public void DeleteGift()
        {
            using (var delete = new Database())
            {
                Console.WriteLine("Input name of the gift you wish to delete:");
                var inputName = Console.ReadLine();

                var d = delete.Gifts.Where(f => f.GiftName == inputName).FirstOrDefault();
                if (d != null)
                {
                    delete.Gifts.Remove(d);
                    delete.SaveChanges();
                    Console.WriteLine("Gift deleted!");
                }
                else Console.WriteLine("Cannot find a gift with that giftname!");
            }
            Console.ReadKey();
        }

        public void AssignGift()
        {
            Console.WriteLine("Input firstname of the person who should get a gift:");
            var inputPersonName = Console.ReadLine();

            Console.WriteLine("Input giftname:");
            var inputGiftName = Console.ReadLine();

            using (var assign = new Database())
            {
                var person = assign.People.Include("Gifts").FirstOrDefault(p => p.FirstName == inputPersonName);
                if (person.Gifts != null) person.Gifts = new List<Gift>();

                var gift = assign.Gifts.FirstOrDefault(g => g.GiftName == inputGiftName);
                if (gift != null) person.Gifts.Add(gift);

                assign.Update(person);
                assign.SaveChanges();
            }
            Console.ReadKey();
        }

        public void ReadGiftsOfPerson()
        {
            Console.WriteLine("Input firstname of the person whom´s gifts you want to see:");
            var inputPersonName = Console.ReadLine();
            
            using (var db = new Database())
            {
                var person = db.People.Include("Gifts").FirstOrDefault(p => p.FirstName == inputPersonName);
                if (person != null && person.Gifts != null)
                {
                    foreach (var gift in person.Gifts)
                    {
                        Console.WriteLine(" - " + gift.GiftName);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


