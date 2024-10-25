
//for(int i = 0; i < 10; i++)
//{
//   Console.WriteLine($"i={i+1}");
//} loeb 1-10


//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine($"i={i}");
//} //loeb 10-1


int sum = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i={i}");
    Console.WriteLine($"Current total: {sum}");
    sum= sum + i; //sum+=i
}
//Console.WriteLine($"final total {sum}"); //liidab algele järgneva numbri