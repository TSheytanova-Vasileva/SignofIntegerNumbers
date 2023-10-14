

int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int output = GetMultipleOfEvenAndOdds(number);
Console.WriteLine(output);

int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetSumOfEvenDigit(number);
    int sumOdd = GetSumOfOddDigit(number);
    int rezult = sumEven * sumOdd;
    return rezult;

}
int GetSumOfOddDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {

        int digit = number % 10;
        number /= 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
       
    }
    return sum;
}



int GetSumOfEvenDigit(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
        
    }
    return sum;
}




