using PolymorphismExample;


OperatorOverloading ob1 = new();    
OperatorOverloading ob2 = new();

ob1.Name="Riajul";
ob1.Age = 20;
ob2.Name="Alam";
ob2.Age = 20;

OperatorOverloading ob3 = new();

ob3=ob1+ob2;

Console.WriteLine(ob3.Name);
Console.WriteLine(ob3.Age);

MethodOverloading obj=new();
obj.Add(100, 800);
obj.Add("Riajul","Alam");
obj.Add(895.258,55.98);

parent p = new child();
p.print();
Console.ReadLine();