using UniqueSubsetsOfStringUsingRecursion;

var uniqueSubsetsOfString = new UniqueSubsetsOfString();

Console.Write("\" \"");
var map = new HashSet<string>();
uniqueSubsetsOfString.UniqueSubsets("", "aab",map);

foreach(var subset in map)
    Console.Write(subset + ", ");
