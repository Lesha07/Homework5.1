Console.WriteLine("Number first:");
int firstNubmer = Int32.Parse(Console.ReadLine());

int secondNubmer = 0;

try
{
    int result = firstNubmer / secondNubmer;
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Division by zero is impossible!");
}