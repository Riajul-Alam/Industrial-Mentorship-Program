
using ICloneableExample2;

Product product1=new Product("Milk",45);
Product product2 = (Product)product1.Clone();
Console.WriteLine(product2.Name);