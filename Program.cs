using CsharpAdvanced.LINQquerySyntax;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/28");
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where) : ");
        new RestrictionOperators().LowNumbers();

    }
}
