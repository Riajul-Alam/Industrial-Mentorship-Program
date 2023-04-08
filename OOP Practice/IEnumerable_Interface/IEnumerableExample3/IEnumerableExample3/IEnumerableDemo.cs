using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample3
{
    public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Standard { get; set; }
    }
    public class School:IEnumerable
    {
        List<Student> students= new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
}









