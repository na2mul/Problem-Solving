using JosephusProblemUsingRecursion;

var josephusProblem = new JosephusProblem();

var list = new List<int>();

for(int i = 1; i<= 40; i++)
{
    list.Add(i);
}

int number = josephusProblem.FindSurvivorNumber(list, 7);

Console.WriteLine(number);