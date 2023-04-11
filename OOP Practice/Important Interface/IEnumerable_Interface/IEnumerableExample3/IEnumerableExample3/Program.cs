
using IEnumerableExample3;


//List<Student> students=new List<Student>();

School students = new School();

Student st1=new Student();
st1.Id=1;st1.Name="Rakib";st1.Standard=3;
students.Add(st1);
Student st2=new Student();
st2.Id=2; st2.Name="Rahim"; st2.Standard=4;
students.Add(st2);
Student st3 = new Student();
st3.Id=3; st3.Name="Riaj"; st3.Standard=5;
students.Add(st3);

// gives error because we can't inherit IEnumerable interface
//and we can't itarate because there no GetEnumerator method in School class

// After implementing GetEnumerator function error gone

foreach (Student student in students)  
{
    Console.WriteLine(student.Id+" "+ student.Name+" "+student.Standard);
}














