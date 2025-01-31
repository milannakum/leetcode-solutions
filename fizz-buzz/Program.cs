// Link: https://leetcode.com/problems/fizz-buzz/
// Name: 412. Fizz Buzz

IList<string> FizzBuzz(int n)
{
    List<string> result = new List<string>(n) { "1" };
    for (int i = 1; i < n; i++)
    {
        int num = i + 1;
        bool divisibleBy3 = num % 3 == 0;
        bool divisibleBy5 = num % 5 == 0;

        if (divisibleBy3 && divisibleBy5) result.Add("FizzBuzz");
        else if (divisibleBy3) result.Add("Fizz");
        else if (divisibleBy5) result.Add("Buzz");
        else result.Add(num.ToString());
    }
    return result;
}
