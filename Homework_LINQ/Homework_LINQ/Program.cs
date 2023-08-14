using System;

namespace Homework_LINQ
{
    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            List<Contact> contactList =  new List<Contact>{
                new Contact("Ivan", "0634092123", "Microsoft"),
                new Contact("Andrew", "0639659205", "Google"), 
                new Contact("Maxim", "0782095558", "Apple"),
                new Contact("Danil", "0680045892", "Apple"),
                new Contact("Susan", "0983459213", "Microsoft")
            };

            IEnumerable<string> contacts = contactList
                .OrderBy(person => person.Number)
                .ThenBy(person => person.Name)
                .Where(person => person.Number.Contains('8'))
                .Select(person => person.ToString());
            contactList.Add(new Contact("Igor", "0931894602", "Google"));
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }

            Console.WriteLine();
            var grouped = contactList.GroupBy(person => person.Company);
            foreach (var contact in grouped)
            {
                Console.WriteLine($"{contact.Key}");
                foreach(var person in contact)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}

