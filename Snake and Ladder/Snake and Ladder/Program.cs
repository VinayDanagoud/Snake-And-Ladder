// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome TO Snake And Ladder");


const int Start = 0;
const int Finish = 100;
const int Noplay = 0,
          Ladder = 1,
          Snake = 2;
Random random = new Random();

int Roll_Dice()
{
    // random value is given to palyer's dice
    return random.Next(1, 7);
}
int Player_Move_Option(int player_Roll_Dice)
{
    // Player Option is gentrated..
    int check_Player_Option = random.Next(0, 3);
    int player_Move = 0;
    switch (check_Player_Option)
    {
        case Ladder:
            player_Move = player_Roll_Dice;
            break;
        case Snake:
            player_Move = -player_Roll_Dice;
            break;
        default:
            break;
    }
    return player_Move;
}

{

    // player initial position
    int player_position = 0, player_Next_Position;

    //Repeats till the Player reaches the winning position 100.
    while (player_position < Finish)
    {
        // player rolls the dice and gets the value
        int player_Roll_Dice = Roll_Dice();

        // The Player then checks for a Option. They are No_Play,Ladder and Snake.
        int player_move = Player_Move_Option(player_Roll_Dice);
        player_Next_Position = player_position + player_move;

        if (player_Next_Position < Start)
            player_position = Start;
        else
            player_position = player_Next_Position;
    }
    Console.WriteLine("Player current position After the game is " + player_position);
}



