namespace PigDice
{
    class Program
    {
        public static void Main(string[] args)
        {
            RollDice();
        }

        public static void RollDice()
        {
            int score = 0;
            Random rd = new Random();
            int turn = 0;

            while(score < 20)
            {
                turn++;
                Console.WriteLine("---------------TURN "+turn+"--------------");
                int currScore = 0;
                do
                {
                    Console.WriteLine("Roll or hold ? (r / h) : ");
                    char ch;
                    while(!char.TryParse(Console.ReadLine(), out ch))
                    {
                        Console.WriteLine("Invalid option");
                    }

                    if(ch == 'r')
                    {
                        int num = rd.Next(1, 7);
                        Console.WriteLine($"Die: {num}");
                        if(num == 1)
                        {
                            Console.WriteLine("Turn over. No score.");
                            break;
                        }
                        currScore += num;
                        if(currScore + score >= 20)
                        {
                            Console.WriteLine($"-----Score for turn: {currScore} --------------");
                            Console.WriteLine($"-----Total Score {score + currScore} ------------");
                            score += currScore;
                            break;
                        }
                    }else if(ch == 'h')
                    {
                        Console.WriteLine($"-----Score for turn: {currScore} --------------");
                        Console.WriteLine($"-----Total Score {score + currScore} ------------");
                        score += currScore;
                        currScore = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }


                } while (score + currScore < 20);
                
            }
            
            Console.WriteLine($"\nYou finished in {turn} turns!");

        }

    }
}