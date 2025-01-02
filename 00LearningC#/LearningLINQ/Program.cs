IEnumerable<int> collection = [1, 2, 3, 4, 5];

#region Filter

IEnumerable<int> filtercollection = [1, 2, 3, 4, 5];

// WHERE - conditional filtering

// filtercollections.Where(x => x % 2 == 0).Dump();

// OfType - conditional fitering bases on type

IEnumerable<object> oftypecollection = [1, 2, 3, 4, 5, "asdf"];

// oftypecollection.OfType<string>().Dump();
// oftypecollection.OfType<int>().Dump();

#endregion

#region Partition

IEnumerable<int> partitionCollection = [1, 2, 3, 4, 5];

// Skip - skip first n elements

// partitionCollection.Skip(3).Dump();

// Take - take first n elements

// partitionCollection.Take(3).Dump();

// SkipLast - skip last 3 elements

// partitionCollection.SkipLast(3).Dump();

// TakeLast - take last 3 elementss

// partitionCollection.TakeLast(3).Dump();

// SkipWhile - Skip while condition is not matched first time

// partitionCollection.SkipWhile(x => x % 3 != 0).Dump();

// TakeWhile - Take first n while condition is matched first time

// partitionCollection.TakeWhile(x => x % 3 != 0).Dump();

// Some combination examples

// partitionCollection.Skip(2).Take(2).Dump(); // 3, 4

// partitionCollection.Take(-3).Dump(); //! DOESN'T WORK

#endregion

#region Projection - Means can convert into a different subtype

IEnumerable<object> projectionCollection = [1, 2, 3, 4, 5];

IEnumerable<dynamic> newProjectionCollection = [
    new { Id = 1, Name = "John"},
    new { Id = 2, Name = "Doe"}
];

IEnumerable<dynamic> people = [
    new { Name = "John", Hobbies = new List<string> { "Reading", "Cycling" } },
    new { Name = "Doe", Hobbies = new List<string> { "Painting", "Swimming" } },
    new { Name = "Alice", Hobbies = new List<string> { "Cooking", "Reading" } }
];

// SELECT + with index

// projectionCollection.Select(x => x.ToString()).Dump();
// projectionCollection.Select(x => x * 2).Dump();

// newProjectionCollection.Select(p => p.Name).Dump();

// INDEX

// projectionCollection.Select((x, i) => $"{i}: {x}").Dump();

// SELECTMANY + with index - //! FLATTEN

// people.SelectMany(x => (IEnumerable<string>)x.Hobbies).Distinct().Dump();

// people.SelectMany((x, i) =>  $"{i}: (IEnumerable<string>){x.Hobbies.ToString()}").Dump();

IEnumerable<List<int>> numbers = [[1, 2, 3], [4, 5, 6]];

// numbers.SelectMany(x => x).Dump(); //! FLATTEN

// numbers.SelectMany((x, i) => x.Select((xx, ii) => $"{i} {x} {ii} {xx}")).Dump();

// numbers.SelectMany((x, i) =>  x.Select((xx, ii) => $"{i}: {xx}")).Dump();

// CAST - one type to another type

// projectionCollection.Cast<int>().Dump(); // implicit casting, works
// projectionCollection.Cast<string>().Dump(); // No way to cast implicitly, hence fails

// CHUNK - divides into n sized intervalss

// projectionCollection.Chunk(2).Dump();

#endregion

#region Existence or qty checks

/// Deferred vs Immediate Execution
/// Deferred does not execute unitl it is realized (iterated). 
/// Example
/// 

IEnumerable<int> existenceCollection = [1, 2, 3, 4, 5];

// Any - immediate execution
// existenceCollection.Any(x => x < -1).Dump();
// existenceCollection.Any(x => x > 3).Dump();

// All - immediate exec
// existenceCollection.All(x => x > -1).Dump();

// Contains - immediate exec
// existenceCollection.Contains(5).Dump();

#endregion

#region Sequence Manipulation

IEnumerable<int> sequence = [1, 2, 3, 4, 5];

// Append
// sequence.Append(2).Dump();
// sequence.Dump();

// Prepend
// sequence.Prepend(2).Dump();
// sequence.Dump();


#endregion

#region Aggregation

IEnumerable<int> aggregation = [1, 2, 3, 4, 5];
var persons = new List<dynamic>
{
    new { Name = "Alice", Age = 30 },
    new { Name = "Bob", Age = 45 },
    new { Name = "Charlie", Age = 30 }
};


// Count - better with IEnumerable

// aggregation.Count().Dump();

// TryGetNonEnumeratedCount -- better with ICollection

// aggregation.TryGetNonEnumeratedCount(out int count);
// count.Dump();

// Max + predicate

// aggregation.Max().Dump();

// var maxAge = persons.Max(x => x.Age);
// System.Console.WriteLine(maxAge);

// MaxBy + predicate

// var oldest = persons.MaxBy(x => x.Age);
// System.Console.WriteLine(oldest);

// Min

// aggregation.Min().Dump();

// var minAge = persons.Min(x => x.Age);
// System.Console.WriteLine(minAge);

// MinBy

// var youngest = persons.MinBy(x => x.Age);
// System.Console.WriteLine(youngest);

// Sum

// aggregation.Sum().Dump();
// persons.Sum(x => x.Age).Dump();

// Average

// aggregation.Average().Dump();
// persons.Average(x => x.Age).Dump();

// Aggregate + 3 overloads

// aggregation.Aggregate((acc, y) => acc + y).Dump(); // same as .Sum
// aggregation.Aggregate(0, (acc, y) => acc + y).Dump(); // same as above
// aggregation.Aggregate(10, (acc, y) => acc + y).Dump();
// aggregation.Aggregate(10, (acc, y) => acc + y, agg => "Total: " + agg).Dump();

// persons.Aggregate(0, (acc , y) => acc + y.Age).Dump();

// LongCount - returns count as long

// aggregation.LongCount().ToString().Dump();

#endregion

#region Element Operators

IEnumerable<int> operators = [1, 2, 3, 4, 5];
IEnumerable<int> single = [2];
IEnumerable<int> empty = [];

// First

// operators.First().Dump();
// empty.First().Dump(); // throws exception

// FirstOrDefault -- if collection is empty, exception is thrown in first.

// operators.FirstOrDefault().Dump();
// empty.FirstOrDefault().Dump();

// Single - chekcs if sequence is single or not

// single.Single().Dump();
// empty.Single().Dump(); // throws exception

//SingleOrDefault

// single.SingleOrDefault().Dump();
// empty.SingleOrDefault().Dump();

// Last

// operators.Last().Dump();
// empty.Last().Dump(); // throws exception

// LastOrDefault

// operators.LastOrDefault().Dump();
// empty.LastOrDefault().Dump();

// ElementAt

// operators.ElementAt(0).Dump();
// operators.ElementAt(-1).Dump(); // throws index out of bounds
// operators.ElementAt(5).Dump(); // throws index out of bounds

// ElementAtOrDefault

// operators.ElementAtOrDefault(0).Dump();
// operators.ElementAtOrDefault(-1).Dump();
// operators.ElementAtOrDefault(5).Dump();

// DefaultIfEmpty

// empty.DefaultIfEmpty().Dump();

#endregion

#region Conversion

IEnumerable<int> conversion = [1, 2, 3, 4, 5];

// ToArray

// conversion.ToArray().Dump();

// ToList

// conversion.ToList().Dump();

// ToDictionary

// persons.ToDictionary(p => p.Name).Dump();
// persons.ToDictionary(p => p.Name, p => p.Age).Dump();

// ToHashSet

// persons.ToHashSet().Dump();

//! For a custom object, need to implement GetHashCode and Equals in 

// ToLookup

#endregion

#region Generation

// AsEnumerable

// persons.AsEnumerable().Dump();

// AsQueryable

// persons.AsQueryable().Dump();

// Range

// Enumerable.Range(0, 5).Dump();

// Repeat (what, count)

// Enumerable.Repeat(2, 5).Dump();

// Empty - useful when you need to return an empty sequence from a LINQ query or a method without worrying about null values or additional allocations

// Enumerable.Empty<int>().Dump();

#endregion

#region Set Operations

IEnumerable<int> set = [1, 2, 3, 4, 5, 3, 4, 1];
var people2 = new List<dynamic>
        {
            new { Name = "Charlie", Age = 35 },
            new { Name = "Alice", Age = 28 }
        };

// Distinct

// set.Distinct().Dump();

// DistinctBy

// persons.DistinctBy(p => p.Age).Dump();

// Union

// set.Union([4, 5, 6]).Dump();

// Intersect

// set.Intersect([0]).Dump();
// set.Intersect([4, 5, 6, 0]).Dump();

// Except

// set.Except([4,5,6]).Dump();

// ExceptBy

// persons.ExceptBy([45], p => p.Age).Dump();

// IntersectBy

// persons.IntersectBy([30, 29], p => p.Age).Dump();

// UnionBy

// persons.UnionBy(people2, p => p.Name).Dump();
// persons.UnionBy(people2, p => p.Age).Dump();

// SequenceEqual (Immmediate Execution)

// set.SequenceEqual([1, 2, 3, 4, 5]).Dump();
// set.SequenceEqual([1, 2, 3, 4, 5, 3, 4, 1]).Dump();
// set.SequenceEqual([1, 1, 2, 3, 4, 5, 3, 4]).Dump();

#endregion

#region Joining & Grouping

IEnumerable<int> joining = [1, 2, 3, 4, 5];

// Zip - combines both sequences taking one element at a time from each sequence. Takes count for shortest seq

// joining.Zip([7,8,9,10], ["a", "b", "v"]).Dump();

var customers = new List<dynamic>
        {
            new { Id = 1, Name = "Alice", Age = 45},
            new { Id = 3, Name = "Charlie", Age = 30},
            new { Id = 4, Name = "Bob", Age = 30},
        };

var orders = new List<dynamic>
        {
            new { PersonId = 1, Product = "Laptop" },
            new { PersonId = 2, Product = "Smartphone" },
            new { PersonId = 1, Product = "Tablet" }
        };

// Join

// customers.Join(orders, c => c.Id, o => o.PersonId, (p, o) => new {Name = p.Name, Product = o.Product}).Dump();

// GroupJoin

// customers.GroupJoin(orders, c => c.Id, o => o.PersonId, (p, o) => new {Name = p.Name, Product = o.Select(o => o.Product).DefaultIfEmpty("No Orders")}).Dump();

// Concat

// joining.Concat([2,34]).Dump();

// GroupBy

// customers.GroupBy(c => c.Age).Dump();

// Order

// joining.Order().Dump();

// OrderDescending

// joining.OrderDescending().Dump();

// OrderBy

// customers.OrderBy(c => c.Age).Dump();

// OrderByDescending

// customers.OrderByDescending(c => c.Age).Dump();

// ThenBy -- apply another sort criteria

// customers.OrderBy(p => p.Age).ThenBy(p => p.Id).Dump();

// ThenByDescending

// customers.OrderBy(p => p.Age).ThenByDescending(p => p.Id).Dump();

// Reverse

// joining.Reverse().Dump();

#endregion

#region PLINQ (Parallel LINQ)

// AsParallel

// WithDegreeOfParallelism

// WithExecutionmode

// WithMergeOptions

// AsOrdered
#endregion