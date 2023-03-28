
/*// ref parameter modifier
//ref: The ref keyword is used to pass a parameter by reference
void Increment(ref int x)
{
    x++;
}

int num = 5;
Increment(ref num);
Console.WriteLine(num); // outputs 6


*/






// out parameter modifier
//out:The out keyword is similar to ref, 
//     but it is used for returning values from a method.
bool TryParseInt(string s, out int result)
{
    return int.TryParse(s, out result);
}

string str = "123";
if (TryParseInt(str, out int num))
{
    Console.WriteLine(num); // outputs 123
}







