using I360;

string input = "", input2 = "";
int? defaultValue = null;
try
{
    Console.Write("Please enter an Integer: ");
    input = Console.ReadLine();

    Console.Write("Please enter a default value in case of an exception: ");
    input2 = Console.ReadLine();
    defaultValue = Convert.ToInt32(input2);

}
catch
{
    Console.WriteLine();
    Console.WriteLine("Default value must be an integer, will use 0.");
    defaultValue = 0;
}


Console.WriteLine();
Console.Write("Result without default exception value: ");
Console.WriteLine(I360.Test.ToSafeInt(input).ToString());

Console.Write("Result with default value: ");
Console.WriteLine(input.ToSafeInt(defaultValue).ToString());


