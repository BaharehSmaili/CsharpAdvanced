using CsharpAdvanced.LINQquerySyntax;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/28");
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where) : ");
        new RestrictionOperators().LowNumbers();


        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/03/04");
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where-property) : ");
        new RestrictionOperators().ProductsOutOfStock();
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where-multiple-properties) : ");
        new RestrictionOperators().ExpensiveProductsInStock();
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where-drilldown) : ");
        new RestrictionOperators().DisplayCustomerOrders();
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where-indexed) : ");
        new RestrictionOperators().IndexedWhere();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-syntax) : ");
        new ProjectionOperators().SelectSyntax();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-property) : ");
        new ProjectionOperators().SelectProperty();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-transform) : ");
        new ProjectionOperators().TransformWithSelect();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-case-anonymous) : ");
        new ProjectionOperators().SelectByCaseAnonymous();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-case-tuple) : ");
        new ProjectionOperators().SelectByCaseTuple();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-new-type) : ");
        new ProjectionOperators().SelectAnonymousConstructions();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-new-type-tuple) : ");
        new ProjectionOperators().SelectTupleConstructions();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-subset-properties) : ");
        new ProjectionOperators().SelectPropertySubset();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-with-index) : ");
        new ProjectionOperators().SelectWithIndex();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-with-where) : ");
        new ProjectionOperators().SelectWithWhere();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-many-syntax) : ");
        new ProjectionOperators().SelectFromMultipleSequences();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-many-drilldown) : ");
        new ProjectionOperators().SelectFromChildSequence();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-many-filter) : ");
        new ProjectionOperators().SelectManyWithWhere();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-many-assignment) : ");
        new ProjectionOperators().SelectManyWhereAssignment();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-multiple-where-clauses) : ");
        new ProjectionOperators().SelectMultipleWhereClauses();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (indexed-select-many) : ");
        new ProjectionOperators().IndexedSelectMany();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-syntax) : ");
        new ProjectionOperators().SelectSyntax();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-syntax) : ");
        new ProjectionOperators().SelectSyntax();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-syntax) : ");
        new ProjectionOperators().SelectSyntax();
        Console.WriteLine();

        Console.WriteLine("Projection Operators (select-syntax) : ");
        new ProjectionOperators().SelectSyntax();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Partition Operators (take-syntax) : ");
        new PartitionOperators().TakeSyntax();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (nested-take) : ");
        new PartitionOperators().NestedTake();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (skip-syntax) : ");
        new PartitionOperators().SkipSyntax();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (nested-skip) : ");
        new PartitionOperators().NestedSkip();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (takewhile-syntax) : ");
        new PartitionOperators().TakeWhileSyntax();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (indexed-takewhile) : ");
        new PartitionOperators().IndexedTakeWhile();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (skipwhile-syntax) : ");
        new PartitionOperators().SkipWhileSyntax();
        Console.WriteLine();

        Console.WriteLine("Partition Operators (indexed-skipwhile) : ");
        new PartitionOperators().IndexedSkipWhile();
        Console.WriteLine();

    }
}
