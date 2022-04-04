// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Welcome to Snake And Ladder ");

const int NoPlay = 1;
const int Ladder = 2;
const int Snake = 3;
int playerOnePosition = 0;
Random random = new Random();
int diceRoll;
diceRoll = random.Next(1, 7);
int check = random.Next(1, 4);
switch (check)
{
    case NoPlay:
        playerOnePosition = playerOnePosition + 0;
        break;
    case Ladder:
        playerOnePosition = playerOnePosition + diceRoll;
        break;
    case Snake:
        playerOnePosition = playerOnePosition - diceRoll;
        if (playerOnePosition < 0)
            playerOnePosition = 0;
        break;
}
Console.WriteLine("Position of Player  " + playerOnePosition);


