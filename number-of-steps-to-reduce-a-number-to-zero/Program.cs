// Link: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
// Name: 1342. Number of Steps to Reduce a Number to Zero

int NumberOfSteps(int num)
{
    int result = 0;
    while (num > 0)
    {
        if (num % 2 == 0) num /= 2;
        else num--;
        result++;
    }
    return result;
}
