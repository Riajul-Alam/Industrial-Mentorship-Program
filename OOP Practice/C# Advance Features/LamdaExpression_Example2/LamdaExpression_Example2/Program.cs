
using System.Collections.Generic;




/*List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
List<int> evenNumbers = GetEvenNumbers(numbers);

List<int>GetEvenNumbers(List<int> numbers)
{
    List<int> EvenNumbers=new List<int>();
    foreach(int number in numbers)
    {
        if(number%2==0) EvenNumbers.Add(number);
    }
    return EvenNumbers;
}
*/


// using Lamda expression
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
List<int> evenNumbers =numbers.FindAll(x => x %2==0);


