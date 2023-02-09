Console.WriteLine("Podaj liczbę:");
string number = Console.ReadLine();
List<int> count = new List<int>(new int[10]);

foreach (char digit in number)
{
    int num = digit - '0';
    count[num]++;
}

int i = 0;
foreach (int value in count)
{
    Console.WriteLine("Cyfra " + i + " występuje " + value + " razy");
    i++;
}
Console.ReadLine();

// Zadanie dnia 5