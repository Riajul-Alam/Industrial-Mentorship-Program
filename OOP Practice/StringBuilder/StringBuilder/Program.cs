using System.Text;


StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("world!");
sb.Insert(5, ", ");

string finalString = sb.ToString();
Console.WriteLine(finalString);

sb.Replace("world", "Everyone");
Console.WriteLine(sb);

sb.Remove(5,1);
Console.WriteLine(sb);





