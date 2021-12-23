namespace XmasWish.Utils

{
    public class Menu
    {
        public void mainMenu()
        {
            XmasWish xmasWish = new();
            xmasWish.XmasWishList();

            bool run = true;

            Console.WriteLine("---XMAS WISH---");
            // how to use: add gifts(other than whats already in the gift catalouge...),
            // add person, CRUD, dont forget to add gift to aldrady gifted after xmas is done........
            Thread.Sleep(2000); // förläng
            Console.Clear();

            while (run)
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1) Show ALL "); // lista alla namn m.m och vad de ska få i år
                Console.WriteLine("2) Create new person:"); // ny person
                Console.WriteLine("3) Create new gift:"); // ny gåva i registret     
                Console.WriteLine("4) Read all people: "); // spec. person plus vad de redan fått. välj från lista av namn.
                Console.WriteLine("5) Read all gifts: "); // lista gåvoregister          
                Console.WriteLine("6) Update a person:"); // person
                Console.WriteLine("7) Update a gift:"); //gåva i registret
                Console.WriteLine("8) Delete a person:"); // person
                Console.WriteLine("9) Delete a gift:"); // gåva
                Console.WriteLine("10) Exit");

                string userInput = Console.ReadLine();
                int menuInput = 0;
                int.TryParse(userInput, out menuInput);
                PersonCrud personCrud = new PersonCrud();
                GiftCrud giftCrud = new GiftCrud();

                switch (menuInput)
                {
                    case 1:
                       
                        Console.Clear();
                        break;
                    case 2:
                        personCrud.CreatePerson();
                        Console.Clear();
                        break;
                    case 3:
                     giftCrud.CreateGift();
                        Console.Clear();
                        break;
                    case 4:
                        personCrud.ReadPerson();
                        Console.Clear();
                        break;
                    case 5:
                      giftCrud.ReadGifts();
                        Console.Clear();
                        break;
                    case 6:
                    personCrud.UpdatePerson();
                        Console.Clear();
                        break;
                    case 7:
                        giftCrud.UpdateGift();
                        Console.Clear();
                        break;
                    case 8:
                   personCrud.DeletePerson();
                        Console.Clear();
                        break;
                    case 9:
                        giftCrud.DeleteGift();
                        Console.Clear();
                        break;
                    case 10:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Input a number between 1-10.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
