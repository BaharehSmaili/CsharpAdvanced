using CsharpAdvanced.LINQquerySyntax;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/02/28");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Restriction Operators (where) : ");
        new RestrictionOperators().LowNumbers();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/03/04");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------");
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

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("Created by : Bahareh.Smi");
        Console.WriteLine("Date : 1402/03/11");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderby-syntax) : ");
        new OrderingOperators().OrderbySyntax();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderby-property) : ");
        new OrderingOperators().OrderbyProperty();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderby-user-types) : ");
        new OrderingOperators().OrderByProducts();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderby-custom-comparer) : ");
        new OrderingOperators().OrderByWithCustomComparer();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderbydescending-syntax) : ");
        new OrderingOperators().OrderByDescendingSyntax();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (orderby-descending-type) : ");
        new OrderingOperators().OrderProductsDescending();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (desc-custom-comparer) : ");
        new OrderingOperators().DescendingCustomComparer();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (thenby-syntax) : ");
        new OrderingOperators().ThenBySyntax();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (thenby-custom) : ");
        new OrderingOperators().ThenByCustom();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (thenby-ordering) : ");
        new OrderingOperators().ThenByDifferentOrdering();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (thenby-custom-descending) : ");
        new OrderingOperators().CustomThenByDescending();
        Console.WriteLine();

        Console.WriteLine("Ordering Operators (reverse) : ");
        new OrderingOperators().OrderingReversal();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (groupby-syntax) : ");
        new GroupingOperators().GroupingSyntax();
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (groupby-property) : ");
        new GroupingOperators().GroupByProperty();
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (groupby-category) : ");
        new GroupingOperators().GroupByCategory();
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (nested-groupby) : ");
        new GroupingOperators().NestedGrouBy();
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (roupby-custom-comparer) : ");
        new GroupingOperators().GroupByCustomComparer();
        Console.WriteLine();

        Console.WriteLine("Grouping Operators (nested-groupby-custom) : ");
        new GroupingOperators().NestedGroupByCustom();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Set Operators (distinct-syntax) : ");
        new SetOperators().DistinctSyntax();
        Console.WriteLine();

        Console.WriteLine("Set Operators (distinct-property-values) : ");
        new SetOperators().DistinctPropertyValues();
        Console.WriteLine();

        Console.WriteLine("Set Operators (union-syntax) : ");
        new SetOperators().UnionSyntax();
        Console.WriteLine();

        Console.WriteLine("Set Operators (union-query-results) : ");
        new SetOperators().UnionOfQueryResults();
        Console.WriteLine();

        Console.WriteLine("Set Operators (intersect-syntax) : ");
        new SetOperators().IntersectSynxtax();
        Console.WriteLine();

        Console.WriteLine("Set Operators (intersect-different-queries) : ");
        new SetOperators().IntersectQueryResults();
        Console.WriteLine();

        Console.WriteLine("Set Operators (distinct-syntax) : ");
        new SetOperators().DifferenceOfSets();
        Console.WriteLine();

        Console.WriteLine("Set Operators (except-syntax) : ");
        new SetOperators().DifferenceOfQueries();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Conversion Operators (convert-to-array) : ");
        new ConversionOperators().ConvertToArray();
        Console.WriteLine();

        Console.WriteLine("Conversion Operators (convert-to-list) : ");
        new ConversionOperators().ConvertToList();
        Console.WriteLine();

        Console.WriteLine("Conversion Operators (convert-to-dictionary) : ");
        new ConversionOperators().ConvertToDictionary();
        Console.WriteLine();

        Console.WriteLine("Conversion Operators (convert-to-type) : ");
        new ConversionOperators().ConvertSelectedItems();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Element Operators (first-element) : ");
        new ElementOperators().FirstElement();
        Console.WriteLine();

        Console.WriteLine("Element Operators (first-matching-element) : ");
        new ElementOperators().FirstMatchingElement();
        Console.WriteLine();

        Console.WriteLine("Element Operators (first-or-default) : ");
        new ElementOperators().MaybeFirstElement();
        Console.WriteLine();

        Console.WriteLine("Element Operators (first-matching-or-default) : ");
        new ElementOperators().MaybeFirstMatchingElement();
        Console.WriteLine();

        Console.WriteLine("Element Operators (element-at) : ");
        new ElementOperators().ElementAtPosition();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Generate Sequences (generate-range) : ");
        new GenerateSequences().RangeOfIntegers();
        Console.WriteLine();

        Console.WriteLine("Generate Sequences (generate-repeat) : ");
        new GenerateSequences().RepeatNumber();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Quantifying Members (any-matches) : ");
        new QuantifyingMembers().AnyMatchingElements();
        Console.WriteLine();

        Console.WriteLine("Quantifying Members (any-grouped) : ");
        new QuantifyingMembers().GroupedAnyMatchedElements();
        Console.WriteLine();

        Console.WriteLine("Quantifying Members (all-match) : ");
        new QuantifyingMembers().AllMatchedElements();
        Console.WriteLine();

        Console.WriteLine("Quantifying Members (all-grouped) : ");
        new QuantifyingMembers().GroupedAllMatchedElements();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (count-syntax) : ");
        new AggregatorOperators().CountSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (count-conditional) : ");
        new AggregatorOperators().CountConditional();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (nested-count) : ");
        new AggregatorOperators().NestedCount();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (grouped-count) : ");
        new AggregatorOperators().GroupedCount();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (sum-syntax) : ");
        new AggregatorOperators().SumSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (sum-of-projection) : ");
        new AggregatorOperators().SumProjection();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (grouped-sum) : ");
        new AggregatorOperators().SumGrouped();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (min-syntax) : ");
        new AggregatorOperators().MinSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (min-projection) : ");
        new AggregatorOperators().MinProjection();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (min-grouped) : ");
        new AggregatorOperators().MinGrouped();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (min-each-group) : ");
        new AggregatorOperators().MinEachGroup();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (max-syntax) : ");
        new AggregatorOperators().MaxSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (max-projection) : ");
        new AggregatorOperators().MaxProjection();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (max-grouped) : ");
        new AggregatorOperators().MaxGrouped();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (max-each-group) : ");
        new AggregatorOperators().MaxEachGroup();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (average-syntax) : ");
        new AggregatorOperators().AverageSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (average-projection) : ");
        new AggregatorOperators().AverageProjection();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (average-grouped) : ");
        new AggregatorOperators().AverageGrouped();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (aggregate-syntax) : ");
        new AggregatorOperators().AggregateSyntax();
        Console.WriteLine();

        Console.WriteLine("Aggregator Operators (aggregate-seeded) : ");
        new AggregatorOperators().SeededAggregate();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Sequence Operations (equal-sequence) : ");
        new SequenceOperations().EqualSequence();
        Console.WriteLine();

        Console.WriteLine("Sequence Operations (not-equal-sequence) : ");
        new SequenceOperations().Linq97();
        Console.WriteLine();

        Console.WriteLine("Sequence Operations (concat-series) : ");
        new SequenceOperations().ConcatSeries();
        Console.WriteLine();

        Console.WriteLine("Sequence Operations (concat-projections) : ");
        new SequenceOperations().ConcatProjection();
        Console.WriteLine();

        Console.WriteLine("Sequence Operations (dot-product) : ");
        new SequenceOperations().DotProduct();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Join Operations (cross-join) : ");
        new JoinOperations().CrossJoinQuery();
        Console.WriteLine();

        Console.WriteLine("Join Operations (group-join) : ");
        new JoinOperations().GroupJoinQquery();
        Console.WriteLine();

        Console.WriteLine("Join Operations (cross-group-join) : ");
        new JoinOperations().CrossGroupJoin();
        Console.WriteLine();

        Console.WriteLine("Join Operations (left-outer-join) : ");
        new JoinOperations().LeftOuterJoin();
        Console.WriteLine();
    }
}
