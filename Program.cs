using System;

namespace FirstProgramme
{
    class Program
    {
        static void StartGame(int heal)
        {
            const int NUMBER_MIN = 1;
            const int NUMBER_MAX = 10;


            Random rnd = new Random();
            int magicNumber = rnd.Next(NUMBER_MIN, NUMBER_MAX + 1);

            do
            {
                Console.WriteLine($"\nVies restantes : {heal}");
                Console.Write($"Rentez un nombre entre {NUMBER_MIN} et {NUMBER_MAX} : ");

                int userAnswerInt = NUMBER_MIN - 1;

                while (userAnswerInt < NUMBER_MIN || userAnswerInt > NUMBER_MAX) // check if the number entered by the user is correct
                {
                    string userAnswerStr = Console.ReadLine();

                    try
                    {
                        userAnswerInt = int.Parse(userAnswerStr);

                        if (userAnswerInt < NUMBER_MIN || userAnswerInt > NUMBER_MAX)
                        {
                            throw new Exception($"[Error] : incorrect the name must be between {NUMBER_MIN} and {NUMBER_MAX}");
                        }
                    }
                    catch
                    {
                        Console.Write($"Rentez un nombre entre {NUMBER_MIN} et {NUMBER_MAX} : ");
                    }
                }

                if(userAnswerInt == magicNumber)
                {
                    Console.WriteLine($"\n -=== Bravo vous avez trouvé le nombre magique ===- \n");
                    break;
                }
                else if(userAnswerInt < magicNumber)
                {
                    Console.WriteLine($" --Le nombre magique est plus grand-- ");       
                }
                else
                {
                    Console.WriteLine($" --Le nombre magique est plus petit-- ");
                }
                heal--;
            }
            while (heal != 0);

            if (heal == 0)
            {
                Console.WriteLine($"\n -=== Vous avez perdu, le nombre magique était {magicNumber} ===- \n");
            }
        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            StartGame(4);
        }
    }
}