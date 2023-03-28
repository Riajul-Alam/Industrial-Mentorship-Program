using Practice_Problem_01;

public class Program
{
    public static void Main(string[] args)
    {
        WaterBottle bottle = new WaterBottle("Red", 300);
        bottle.WaterAmount=100;
        bottle.IsOpen = true;
        bottle.AddWater(50);


        WaterBottle bottle2 = new WaterBottle("Blue", 400);
        bottle2.IsOpen = false;  
        bottle2.WaterAmount=150;
        bottle2.AddWater(100);

        Console.WriteLine(bottle.WaterAmount);
        Console.WriteLine(bottle.Color);
        Console.WriteLine(bottle.IsOpen);
    }
}