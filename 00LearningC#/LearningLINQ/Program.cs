﻿using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

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

IEnumerable<List<int>> numbers = [[1,2,3], [4,5,6]];

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

// Append


// Prepend


#endregion


#region Aggregation

// Count

// TryGetNonEnumeratedCount

// Max + predicate

// MaxBy + predicate

// Min

// MinBy

// Sum

// Average

// Aggregate + 3 overloads

// LongCount

#endregion

#region Element Operators

// First

// FirstOrDefault -- if collection is empty, exception is thrown

// Single

//SingleOrDefault

// Last

// LastOrDefault

// ElementAt

// ElementAtOrDefault

// DefaultIfEmpty

#endregion

#region Conversion

// ToArray

// ToList

// ToDictionary

// ToHashSet

// ToLookup

#endregion

#region Generation

// AsEnumerable

// AsQueryable

// Range

// Repeat

// Empty
#endregion

#region Set Operations

// Distinct

// DistinctBy

// Union

// Intersect

// Except

// ExceptBy

// IntersectBy

// UnionBy

// SequenceEqual (Immmediate Execution)
#endregion

#region Joining & Grouping

// Zip

// Join

// GroupJoin

// Concat

// GroupBy

// Order

// OrderDescending

// OrderByDescending

// ThenBy

// ThenByDescending

// Reverse
#endregion

#region PLINQ (Parallel LINQ)

// AsParallel

// WithDegreeOfParallelism

// WithExecutionmode

// WithMergeOptions

// AsOrdered
#endregion