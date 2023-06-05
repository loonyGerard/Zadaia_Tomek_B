int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// #1
Console.WriteLine(numbers);

// #2
for (var i = 0; i<numbers.Length; i++){
    var x = numbers[i];
    Console.WriteLine(x);
}

// #3
numbers[0] = 20;
numbers[numbers.Length-1] = 30;

for (var i = 0; i < numbers.Length; i++)
{
    var x = numbers[i];
    Console.WriteLine(x);
}

// #4
for (var i = 0; i < numbers.Length;i++)
{
    numbers[i] *= 2;
}
for (var i = 0; i < numbers.Length; i++)
{
    var x = numbers[i];
    Console.WriteLine(x);
}
// #5
GetRandom(2,20);
void GetRandom(int a, int b){
    Random random = new Random();
    int randomNumber = random.Next(a, b);
    Console.WriteLine(random);
}

//#6
void GetRandomArray(int lenght, int min, int max)
{
    Random random = new Random();
    int[] randomArray = new int[lenght];

    for (var i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = random.Next(min, max);
    }
       
}

// #7
int Sum(int[] numbers)
{
    int sum = 0;
    for (var i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
        return sum;
}