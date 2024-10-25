
Random rnd= new Random();
int cpuRandom;


bool loopActive = true; // boolean väärtus õige v vale

while(loopActive)
{
    cpuRandom = rnd.Next(1,4);
    //Console.WriteLine($"cpu has genereted {cpuRandom}");
    Console.WriteLine("make a guess. Enter a number 1-3");
    
    int userNumber= Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("congratulations, you won");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("oops try again");
    }
}

Console.WriteLine("have a nice day");