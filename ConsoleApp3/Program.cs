int n1, n2, n3, n4, n5, n6, n7, n8, n9, round, turnnn, turn_number, player_score, computer_score, temp;
string turn = "Player"; turn_number = 1; round = 1; computer_score = 0; player_score = 0; turnnn = 0;

Console.WriteLine("             Welcome to our game :d "); Console.WriteLine(); Console.WriteLine("                 CREATE  BOARD");
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");

Console.SetCursorPosition(18, 5); n1 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 5); n2 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 5); n3 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(18, 7); n4 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 7); n5 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 7); n6 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(18, 9); n7 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 9); n8 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 9); n9 = Convert.ToInt16(Console.ReadLine());

Console.SetCursorPosition(10, 15); Console.WriteLine();
Console.WriteLine("             |------Round " + round + "------|");
Console.WriteLine();
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");

while (round < 6)
{
    Console.WriteLine(); Console.WriteLine("Please choose a move from 1 to 6");
    string hamle_numarası = Convert.ToString(Console.ReadLine());

    if (hamle_numarası == "1")
    {

        temp = n1; n1 = n3; n3 = n2; n2 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else if (hamle_numarası == "2")
    {
        temp = n4; n4 = n6; n6 = n5; n5 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else if (hamle_numarası == "3")
    {
        temp = n7; n7 = n9; n9 = n8; n8 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else if (hamle_numarası == "4")
    {
        temp = n1; n1 = n7; n7 = n4; n4 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else if (hamle_numarası == "5")
    {
        temp = n2; n2 = n8; n8 = n5; n5 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else if (hamle_numarası == "6")
    {
        temp = n3; n3 = n9; n9 = n6; n6 = temp;
        turn_number = turn_number + 1;
        if (turnnn % 2 == 0)
            turn = "Computer";
        else if (turnnn % 2 == 1)
            turn = "Player";
        turnnn = turnnn + 1;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "    /    " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
    }
    else
        Console.WriteLine("invalid move number");
    Console.WriteLine();
}
