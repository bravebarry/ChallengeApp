Console.WriteLine("Podaj liczbę:");
string number = Console.ReadLine();
List<int> count = new List<int>(new int[10]);

foreach (char digit in number)
{
    int num = digit - '0';
    count[num]++;
}

for (int i = 0; i < 10; i++)
    Console.WriteLine("Cyfra " + i + " występuje " + count[i] + " razy");