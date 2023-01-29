using System;

namespace FirstProgramme
{
    class Program
    {
        static void StartGame(int heal)
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(1, 10);

            do
            {
                Console.WriteLine($"\nVies restantes : {heal}");
                Console.Write($"Rentez un nombre entre 1 et 10 : ");

                int userAnswerInt = 0;

                while (userAnswerInt < 1 || userAnswerInt > 10)
                {
                    string userAnswerStr = Console.ReadLine();

                    try
                    {
                        userAnswerInt = int.Parse(userAnswerStr);

                        if (userAnswerInt <= 0)
                        {
                            throw new Exception("[Error] : incorrect the name must be between 1 and 10");
                        }
                    }
                    catch
                    {
                        Console.Write($"Rentez un nombre entre 1 et 10 : ");
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
                    heal--;
                }
                else
                {
                    Console.WriteLine($" --Le nombre magique est plus petit-- ");
                    heal--;
                }
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