using System.Collections;

#region 1st, ArrayList
ArrayList list = new ArrayList();

// Add elements to list
list.Insert(0, "abdullah 123");
list.Add(5);
list.Add("Abdullah");
list.Add(true);
list.Add("Mohammad");
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);
list.Add(11);
list.Insert(4, "abdullah 45");

// Remove elements from list
list.Remove(5);
list.RemoveAt(0);

//print all elements
foreach (var element in list)
{
    Console.WriteLine(element);
}

Console.WriteLine("List");
Console.WriteLine(list[0]);
#endregion

Console.WriteLine("---------------------");


#region 2nd, ArrayList
ArrayList list2 = new ArrayList()
{
    "c#", 
   "java",
  "python"
};

string pl = Console.ReadLine();
if (list2.Contains(pl.ToLower()))
{ 
    Console.WriteLine("Exist, index: " + list.IndexOf(pl));
}
    Console.WriteLine("Number of items: " + list.Count);

#endregion