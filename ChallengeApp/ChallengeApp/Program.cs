// praca domowa dnia 4
namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ewa";
            string gender = "Kobieta";
            int age = 33;

            if (gender == "Kobieta" && age < 30)
            {
                Console.WriteLine("Kobieta poniżej 30 lat");
            }
            else if (name == "Ewa" && age == 33)
            {
                Console.WriteLine("Ewa, lat 33");
            }
            else if (gender == "Mężczyzna" && age < 18)
            {
                Console.WriteLine("Niepełnoletni Mężczyzna");
            }
        }
    }
}