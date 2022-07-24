var originList = new SortedList<string, string>();

originList.Add("andriikorshenko@gmail.com", "Andrii Korshenko");
originList.Add("varshavinartem@i.ua", "Artem Varshavin");
originList.Add("marininaanastasiya@ukr.net", "Anastasiya Marinina");

foreach (var item in originList)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

Console.WriteLine(new String('-', 3));

var reversedSort = from p in originList
                  orderby p.Key descending
                  select p;

foreach (var item in reversedSort)
{
    Console.WriteLine(item.Key + " " + item.Value);
}