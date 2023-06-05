int[] numbers =[1, 2, 3, 4, 5, 6, 7, 8, 9];
// #1
Console.WriteLine(numbers);

// #2
for (var i = 0; int<numbers.Length; int++){
    x = numbers[i];
    Console.WriteLine(x);
}

// #3
numbers[0] = 20;
numbers[numbers.Length] = 30;
for (var i = 0; int < numbers.Length; int++)
{
    x = numbers[i];
    Console.WriteLine(x);
}

// #4
for (var i = 0; int < numbers.Length; int++)
{
    numbers[i]*=2
}
for (var i = 0; int < numbers.Length; int++)
{
    x = numbers[i];
    Console.WriteLine(x);
}
// #5
Random random = new Random();
int randomNumber = random.Next(3,33);
Console.WriteLine(random);

//#6