Random rnd = new Random();


//int myRandomNumb = rnd.Next(0, 11); // 0-10

//Console.WriteLine($"My random number is : {myRandomNumb}");

int RandomNumb;

int RandomSum = 0;
for(int i = 0; i<3; i++)
{
    int myRandomNumb = rnd.Next(0, 11); // 0-10
    RandomSum= RandomSum+ myRandomNumb;
    Console.WriteLine($"My random number is : {myRandomNumb}");

}

Console.WriteLine($"My random sum total: {RandomSum}");