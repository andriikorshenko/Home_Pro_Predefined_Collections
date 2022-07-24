using System.Collections.Generic;
using System.Collections.Specialized;

Dictionary<long, double> myDictionary = 
    new Dictionary<long, double>();
myDictionary.Add(343412346534, 653312.32);
myDictionary.Add(123412323234, 2233312.32);
myDictionary.Add(834546341234, 23412.32);

foreach (var item in myDictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

Console.WriteLine(new String('-', 20));

SortedList<long, double> mySortedList = 
    new SortedList<long, double>();
mySortedList.Add(343412346534, 653312.32);
mySortedList.Add(123412323234, 2233312.32);
mySortedList.Add(834546341234, 23412.32);

foreach (var item in mySortedList)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

Console.WriteLine(new String('-', 20));

SortedDictionary<long, double> mySortedDictionary = 
    new SortedDictionary<long, double>();
mySortedDictionary.Add(343412346534, 653312.32);
mySortedDictionary.Add(123412323234, 2233312.32);
mySortedDictionary.Add(834546341234, 23412.32);

foreach (var item in mySortedDictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

Console.WriteLine(new String('-', 20));