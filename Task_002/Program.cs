var myShop = new SortedDictionary<string, List<string>>();

// Add some buyers to the database with a first purchase.
myShop.Add("Martin A. Alone", new List<string>() { "CD Player", "Blender" });
myShop.Add("Karry S. Smith", new List<string>() { "Mixer" });
myShop.Add("Alex J. Jonson", new List<string>() { "Plates" });

// Extra purchases after a while.
myShop["Martin A. Alone"].Add("TV");
myShop["Karry S. Smith"].Add("DVD Player");
myShop["Alex J. Jonson"].Add("TV");

Console.WriteLine("Who had bought a TV?");

foreach (var buyer in myShop)
{
    foreach (var item in buyer.Value)
    {
        if (item == "TV")
        {
            Console.WriteLine("> " + buyer.Key);
        }
    }
}

Console.WriteLine("\nWhat is Karry's S. Smith buying history?");

foreach (var buyer in myShop)
{
    if (buyer.Key == "Karry S. Smith")
    {
        foreach (var item in buyer.Value)
        {
            Console.WriteLine("> " + item);
        }
    }
}