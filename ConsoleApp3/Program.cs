int n1, n2, n3, n4, n5, n6, n7, n8, n9,round,turnnn,turn_number,player_score, computer_score, temp1, temp2, temp3, temp4, temp5, temp6;
string turn = "Player"; turn_number = 1; round = 1; computer_score = 0; player_score = 0; turnnn = 0;

Console.WriteLine("Welcome to our game :d "); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your first number is "+ n1); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your second number is " + n2); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your third number is " + n3); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n4 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your fourth number is " + n4); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n5 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your fifth number is " + n5); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n6 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your sixth number is " + n6); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n7 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your seventh number is " + n7); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n8 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your eighth number is " + n8); Console.WriteLine(); Console.WriteLine();

Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n9 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Your nineth number is " + n9); Console.WriteLine(); Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("             |------Round "+round+"------|");
Console.WriteLine();
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     "+turn_number +"    /    "+turn);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : "+player_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : "+computer_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");

bool apple = true;
while (apple)
{
    int hamle_numarası;
    Console.WriteLine("Please choose a move from 1 to 6");
    hamle_numarası = Convert.ToInt32(Console.ReadLine());

    if (hamle_numarası == 1)
    {

        temp1 = n1; n1 = n3; n3 = n2; n2 = temp1;
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
    else if (hamle_numarası == 2)
    {
        temp2 = n4; n4 = n6; n6 = n5; n5 = temp2;
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


    else if (hamle_numarası == 3)
    {
        temp3 = n7; n7 = n9; n9 = n8; n8 = temp3;
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

    else if (hamle_numarası == 4)
    {
        temp4 = n1; n1 = n7; n7 = n4; n4 = temp4;
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
    else if (hamle_numarası == 5)
    {
        temp5 = n2; n2 = n8; n8 = n5; n5 = temp5;
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

    else if (hamle_numarası == 6)
    {
        temp6 = n3; n3 = n9; n9 = n6; n6 = temp6;
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
