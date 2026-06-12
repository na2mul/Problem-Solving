using PermutationWithSpaceUsingRecursion;

var permutationWithSpace = new PermutationWithSpace();
string str = "abc";
string output = str[0].ToString(), input = str.Remove(0, 1);
permutationWithSpace.Permuation(output, input);
