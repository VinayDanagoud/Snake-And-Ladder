// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To play Snake And Ladder");

//Declaring Constants
const int Ladder = 1;
const int Snake = 2;
const int NoPlay = 0;

int CurrentPlayer = 1;
int PosPlayer = 0;
int PosPlayer1 = 0;
int PosPlayer2 = 0;
int NumofDiceRolled = 0;

while (PosPlayer1 < 100 && PosPlayer2 < 100)
{
    //Re-Initialize the variables
    if (CurrentPlayer == PosPlayer1)
    {
        PosPlayer = PosPlayer1;
    }
    else
    {
        PosPlayer = PosPlayer2;
    }

    PosPlayer++;
    NumofDiceRolled++;

    Random random = new Random();      //initiatizlize the random class
    int DiceRolled = random.Next(7);   //class to generate randome number from 1 - 6
    Console.WriteLine("Number of times the dice was Rolled : " + DiceRolled);



    int ResultSnake = random.Next(3); // 1=Ladder , 2=Snake, 0=NoPlay

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
        if (PosPlayer - DiceRolled >= 0)
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

    //Re-Assing the Return variables
    if (CurrentPlayer == PosPlayer1)
    {
        PosPlayer1 = PosPlayer;
        CurrentPlayer = 2;
    }
    else
    {
        PosPlayer2 = PosPlayer;
        CurrentPlayer = 1;
    }
}
if (PosPlayer1 == 100)
{
    Console.WriteLine("Player One Wins");
}
else if (PosPlayer2 == 100)
{
    Console.WriteLine("Player Two Wins");
}
Console.WriteLine("Number Of time the dice was rolled : " + NumofDiceRolled);

