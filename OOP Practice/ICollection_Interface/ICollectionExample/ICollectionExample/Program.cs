using ICollectionExample;

MyCollection myCollection = new MyCollection();

myCollection.Add("apple");
myCollection.Add("banana");
myCollection.Add("cherry");

Console.WriteLine(myCollection.Count);

foreach (string item in myCollection)
{
    Console.WriteLine(item);
}

myCollection.Remove("banana");

Console.WriteLine(myCollection.Count);

foreach (string item in myCollection)
{
    Console.WriteLine(item);
}
