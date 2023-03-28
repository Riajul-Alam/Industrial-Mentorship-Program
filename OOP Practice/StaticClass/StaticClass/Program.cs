


using StaticClass;

Calculator calc = new Calculator();
var result=calc.CalculateAverage(new double[] {2.6,2.5,3.5});//gives error


var result1 = Calculator.CalculateAverage(new double[] { 4.5, 8.5, 3, 4 });
Console.WriteLine(result1);








