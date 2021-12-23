namespace XmasWish.Utils

{
    public class Menu
    {
        public void mainMenu()
        {
            XmasWish xmasWish = new();
            xmasWish.XmasWishList();

            bool run = true;
            Console.WriteLine("       ---------------------------------------------------");
            Console.WriteLine("       -*-*-*-*-*-*-*-*-*-*-XMAS WISH-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("       ---------------------------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("HOW TO USE:");
            Console.WriteLine("Add the people you are giving gifts to this Xmas!");
            Console.WriteLine("Chose a gift from the list of gifts or create your own!");
            Console.WriteLine("Explore and see your Xmas Wishes come true!");
            Console.WriteLine("****************************************************************");
            Thread.Sleep(5000); 
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();
            Console.Clear();

            while (run)
            {
                Console.WriteLine("       ---------------------------------------------------");
                Console.WriteLine("       -*-*-*-*-*-*-*-*-*-*---MENU---*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("       ---------------------------------------------------");
                Console.WriteLine("1) Create new person:"); // ny person  
                Console.WriteLine("2) Create new gift:"); // ny gåva i registret     
                Console.WriteLine("3) Read all people: "); // lista personer
                Console.WriteLine("4) Read all gifts: "); // lista gåvor      
                Console.WriteLine("5) Update a person:"); // upd. person
                Console.WriteLine("6) Update a gift:"); // upd. gåva i registret
                Console.WriteLine("7) Delete a person:"); // del. person
                Console.WriteLine("8) Delete a gift:"); // del. gåva
                Console.WriteLine("9) Assign gift to person:"); // tilldela en gåva till en person
                Console.WriteLine("10) See gifts of person:"); // visa gåvor tilldelade en person
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("11) Exit");

                string userInput = Console.ReadLine();
                int menuInput = 0;
                int.TryParse(userInput, out menuInput);
                PersonCrud personCrud = new PersonCrud();
                GiftCrud giftCrud = new GiftCrud();

                switch (menuInput)
                {
                    case 1:
                        personCrud.CreatePerson();
                        Console.Clear();
                        break;
                    case 2:
                        giftCrud.CreateGift();
                        Console.Clear();
                        break;
                    case 3:
                        personCrud.ReadPerson();
                        Console.Clear();
                        break;
                    case 4:
                        giftCrud.ReadGifts();
                        Console.Clear();
                        break;
                    case 5:
                        personCrud.UpdatePerson();
                        Console.Clear();
                        break;
                    case 6:
                        giftCrud.UpdateGift();
                        Console.Clear();
                        break;
                    case 7:
                        personCrud.DeletePerson();
                        Console.Clear();
                        break;
                    case 8:
                        giftCrud.DeleteGift();
                        Console.Clear();
                        break;
                    case 9:
                        giftCrud.AssignGift();
                        Console.Clear();
                        break;
                    case 10:
                        giftCrud.ReadGiftsOfPerson();
                        Console.Clear();
                        break;
                    case 11:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Input a number between 1-11");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
