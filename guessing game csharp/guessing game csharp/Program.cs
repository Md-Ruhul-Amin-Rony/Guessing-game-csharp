
Random slumpat = new Random();

bool myBool = true;
//int gissa = 0;

;



while (myBool)
{
    Console.WriteLine("Welcome to guessing game :  ");
    Console.WriteLine();
    Console.WriteLine("----------------------------------");
    Console.WriteLine("[1] type '1' to play the easy level:");
    Console.WriteLine("[2] type '2' to play the medium level:");
    Console.WriteLine("[3] type '3' to play the hard level:");
    Console.WriteLine("[4] type '4' to stop the game");

    int number = 0;
    Int32.TryParse(Console.ReadLine(), out number);


    switch (number)
    {
        case 1:
            Console.WriteLine("Now you are going to play the Easy Level.");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Write a number between 1 to 20 and you have 5 chances to detect the number:");

            int slumpTal = slumpat.Next(0, 20);
            int guess = 0;

            for (int i = 0; i < 5; i++)
            {



                bool isNumber = Int32.TryParse(Console.ReadLine(), out int tal);

                if (!isNumber)
                {
                    Console.WriteLine("You need to type a number instead!!");
                    continue;
                }
                if (tal < slumpTal)
                {
                    Console.WriteLine($"youa have typed number {tal} which is lower than random number");

                }
                else if (tal > slumpTal)
                {
                    Console.WriteLine($"you have typed number {tal} which is hisgher than random number");
                }
                else if (tal == slumpTal)
                {
                    Console.WriteLine($"WOW!! you have typed the right number after {guess} try. ");
                    break;

                }
                guess++;
                if (i == 4 && myBool == false)
                {
                    Console.WriteLine("Sorry! you have failed to guess the number!!!");
                    myBool = false;
                }

            }
            break;
        case 2:
            Console.WriteLine("Now you are going to play the Medium Level.");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Write a number between 1 to 50 and you have 8 chances to detect the number:");

            int slumpTal1 = slumpat.Next(0, 50);
            int guess1 = 0;

            for (int i = 0; i < 8; i++)
            {


                bool isNumber = Int32.TryParse(Console.ReadLine(), out int tal);

                if (!isNumber)
                {
                    Console.WriteLine("You need to type a number instead!!");
                    continue;
                }
                if (tal < slumpTal1)
                {
                    Console.WriteLine($"youa have typed number {tal} which is lower than random number");

                }
                else if (tal > slumpTal1)
                {
                    Console.WriteLine($"you have typed number {tal} which is hisgher than random number");
                }
                else if (tal == slumpTal1)
                {
                    Console.WriteLine($"WOW!! you have typed the right number after {guess1} try. ");
                    break;
                }
                guess1++;
                if (i == 8 && myBool == false)
                {
                    Console.WriteLine("Sorry! you have failed to guess the number!!!");
                    myBool = false;
                }

            }
            break;
        case 3:
            Console.WriteLine("Now you are going to play the Hard Level.");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Write a number between 1 to 100 and you have 10 chances to detect the number:");

            int slumpTal2 = slumpat.Next(0, 100);
            int guess2 = 0;

            for (int i = 0; i < 10; i++)
            {


                bool isNumber = Int32.TryParse(Console.ReadLine(), out int tal);

                if (!isNumber)
                {
                    Console.WriteLine("You need to type a number instead!!");
                    continue;
                }
                if (tal < slumpTal2)
                {
                    Console.WriteLine($"youa have typed number {tal} which is lower than random number");

                }
                else if (tal > slumpTal2)
                {
                    Console.WriteLine($"you have typed number {tal} which is hisgher than random number");
                }
                else if (tal == slumpTal2)
                {
                    Console.WriteLine($"WOW!! you have typed the right number after {guess2} try. ");
                    break;
                }
                guess2++;
                if (i == 8 && myBool == false)
                {
                    Console.WriteLine("Sorry! you have failed to guess the number!!!");
                    myBool = false;
                }

            }
            break;
        case 4:
            Console.WriteLine("Now you are going to stop the game.Tryck Enter to stop.");
            myBool = false;
            break;




    };
};



