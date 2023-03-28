

// a tuple is a data structure that allows you
// to group together a fixed number of related
// values of different types.

var myTuple = (1, "Hello", true);
int myInt = myTuple.Item1; // 1
string myString = myTuple.Item2; // "Hello"
bool myBool = myTuple.Item3; // true

// nested tuple

var myTuple1 = (1, ("Hello", true));
string myString1 = myTuple1.Item2.Item1; // "Hello"
bool myBool1 = myTuple1.Item2.Item2; // true






