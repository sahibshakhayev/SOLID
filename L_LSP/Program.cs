//// Bad Example

//var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
//SumCalculator sum = new SumCalculator(numbers);
//Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
//Console.WriteLine();
//EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
//Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


//SumCalculator evenSumasSum = new EvenNumbersSumCalculator(numbers);
//Console.WriteLine($"The sum of all the even numbers in Sum Calc: {evenSumasSum.Calculate()}");

//public class SumCalculator
//{
//    protected readonly int[] _numbers;
//    public SumCalculator(int[] numbers)
//    {
//        _numbers = numbers;
//    }
//    public int Calculate() => _numbers.Sum();
//}


//public class EvenNumbersSumCalculator : SumCalculator
//{
//    public EvenNumbersSumCalculator(int[] numbers)
//        : base(numbers)
//    {
//    }
//    public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
//}


// Good Example


var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
Calculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
Console.WriteLine();
Calculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");



public abstract class Calculator
{
    protected readonly int[] _numbers;
    public Calculator(int[] numbers)
    {
        _numbers = numbers;
    }
    public abstract int Calculate();
}


public class SumCalculator : Calculator
{
    public SumCalculator(int[] numbers)
        : base(numbers)
    {
    }
    public override int Calculate() => _numbers.Sum();
}
public class EvenNumbersSumCalculator : Calculator
{
    public EvenNumbersSumCalculator(int[] numbers)
       : base(numbers)
    {
    }
    public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
}


 
       

