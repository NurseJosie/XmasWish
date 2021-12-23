using XmasWish.Models;

namespace XmasWish.Utils
{
    public class PersonCrud
    {
        public void CreatePerson()
        {
            using (var create = new Database())
            {

                Console.WriteLine("Firstname of gift receiver:");
                var createName = Console.ReadLine();

                Console.WriteLine("Lastname of gift receiver:");
                var createLastName = Console.ReadLine();

                Console.WriteLine("How is the receiver related to you?");
                var createRelation = Console.ReadLine();

                Person person = new Person()
                {
                    FirstName = createName,
                    LastName = createLastName,
                    RelationToUser = createRelation,
                };

                create.Add(person);
                create.SaveChanges();
                Console.WriteLine("New person added!");
                Console.ReadKey();
            }
        }
        public void ReadPerson() // listar alla förnamn, efternamn samt Id
        {
            using (var read = new Database())
            {
                var list = read.People.OrderByDescending(p => p.PersonId);
                foreach (var n in list)
                {
                    Console.WriteLine(" - " + n.FirstName + " " + n.LastName + " " + n.RelationToUser);
                }
            }
            Console.ReadKey();
        }

        public void UpdatePerson() //uppdaterar vald person, alla properties
        {
            using (var update = new Database())
            {
                Console.WriteLine("Input firstname of the person you wish to update:");
                var inputName = Console.ReadLine();

                var u = update.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (u != null)
                {
                    Console.WriteLine("Firstname:");
                    var newName = Console.ReadLine();
                    u.FirstName = newName;

                    Console.WriteLine("Lastname:");
                    var newLastName = Console.ReadLine();
                    u.LastName = newLastName;

                    Console.WriteLine("How is the receiver related to you?");
                    string newRelation = Console.ReadLine();
                    u.RelationToUser = newRelation;

                    update.People.Update(u);
                    update.SaveChanges();
                    Console.WriteLine("Person updated!");
                }
                else Console.WriteLine("Cannot find a person with that firstname!");
            }
            Console.ReadKey();
        }
        public void DeletePerson() // söker via förnamn, ta bort från tabellen
        {
            using (var delete = new Database())
            {
                Console.WriteLine("Input firstname of the person you wish to delete:");
                var inputName = Console.ReadLine();

                var d = delete.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (d != null)
                {
                    delete.People.Remove(d);
                    delete.SaveChanges();
                    Console.WriteLine("Person deleted!");
                }
                else Console.WriteLine("Cannot find a person with that firstname!");
            }
            Console.ReadKey();
        }
        public void ShowAll() 
        {
            using (var showAll = new Database())
            {
                var list = showAll.People.OrderByDescending(p => p.PersonId);
                foreach (var n in list)
                {
                    Console.WriteLine(" - " + n.FirstName + " " + n.LastName + " " + n.RelationToUser + " " + n.Gifts);
                }
            }
            Console.ReadKey();
        }
    }
}


    





