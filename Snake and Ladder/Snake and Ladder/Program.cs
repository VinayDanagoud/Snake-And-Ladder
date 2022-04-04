// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To play Snake And Ladder");

//Declaring Constants
const int Ladder = 1;
const int Snake = 2;
const int NoPlay = 3;

int PosPlayer = 0;
int Player = 1;
int NumofDiceRolled = 0;

while (PosPlayer < 100)
{
    PosPlayer++;
    NumofDiceRolled++;
    Random random = new Random();      //initiatizlize the random class
    int DiceRolled = random.Next(7);   //class to generate randome number from 1 - 6
    Console.WriteLine("Number of times the dice was Rolled : " + DiceRolled);



    int ResultSnake = random.Next(4); //class to generate randome number from 1 - 3

    if (ResultSnake == Ladder)
    {
        if (PosPlayer + DiceRolled <= 100)
        {
            PosPlayer = PosPlayer + DiceRolled;
            Console.WriteLine("Ladder");
            Console.WriteLine("Player Current Position : " + PosPlayer);
        }
    }
    else if (ResultSnake == Snake)
    {
        if (PosPlayer + DiceRolled >= 0)
        {
            PosPlayer = PosPlayer - DiceRolled;
        }
        else
        {
            PosPlayer = 0;
        }
        Console.WriteLine("Snake");
        Console.WriteLine("Player Current Position : " + PosPlayer);

    }
    else
    {
        Console.WriteLine("No Play");
    }
}
Console.WriteLine("Number Of time the dice was rolled : " + NumofDiceRolled);

