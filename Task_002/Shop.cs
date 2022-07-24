using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class Shop
    {      
        private NameValueCollection? myCollection;

        public Shop()
        {
            myCollection = new NameValueCollection
            {
                { "TV", "Petr P." },
                { "TV", "Amon S." },
                { "Lamp", "Petr P." },
                { "TV", "Bry M." },
                { "Fridge", "Lary P." },
                { "TV", "Vinseent F." },
                { "Lamp", "Lars P." },
                { "TV", "Bish A." },
                { "Fridge", "Ray P." },
                { "TV", "Tory B." }
            };
        }

        public void FindABuyerByTheCategory(string? category)
        {
            foreach (var item in myCollection.GetValues(category))
            {
                Console.WriteLine(item);
            }
        }
    }
}
