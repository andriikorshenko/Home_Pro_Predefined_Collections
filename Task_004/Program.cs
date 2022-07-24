using System.Collections;
using System.Collections.Specialized;

var myDictionary1 = new OrderedDictionary
{
    { "hello", "world"},
    { "red", "car"},
    { "beautiful", "forest"}
};

var myDictionary2 = new OrderedDictionary
{
    { "hello", "world"},
    { "red", "car"},
    { "beautiful", "forest"}
};

foreach (DictionaryEntry item1 in myDictionary1)
{
    foreach (DictionaryEntry item2 in myDictionary2)
    {
        Console.WriteLine(Comparer.Equals(item1, item2).ToString());
    }
}

