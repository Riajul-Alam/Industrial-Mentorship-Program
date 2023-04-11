using ICloneableExample;

MyObject myObject1 = new MyObject(42, "Hello, world!");
MyObject myObject2 = (MyObject)myObject1.Clone();
MyObject m3 = (MyObject)myObject1.Clone();

Console.WriteLine("myObject1.Number = {0}, myObject1.Text = {1}", myObject1.Number, myObject1.Text);
Console.WriteLine("myObject2.Number = {0}, myObject2.Text = {1}", myObject2.Number, myObject2.Text);
