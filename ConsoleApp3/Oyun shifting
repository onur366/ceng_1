int n1, n2, n3, n4, n5, n6, n7, n8, n9, round, turn_number, player_score, computer_score, temp; string turn = "Player"; string whowon;
turn_number = 0; round = 1; computer_score = 0; player_score = 0; int points = 0; int board_score = 0; int kimin_sırası = 0; int kim_puan_aldı = 0;

Console.WriteLine("             Welcome to my game :dd "); Console.WriteLine(); Console.WriteLine("                 CREATE  BOARD");
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################"); Console.WriteLine();

Console.SetCursorPosition(18, 5); n1 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 5); n2 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 5); n3 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(18, 7); n4 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 7); n5 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 7); n6 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(18, 9); n7 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(23, 9); n8 = Convert.ToInt16(Console.ReadLine());
Console.SetCursorPosition(28, 9); n9 = Convert.ToInt16(Console.ReadLine());

bool x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
bool x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
bool x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
bool x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
bool x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
bool x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
bool x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
bool x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

points = 0;
board_score = 0;

if (x1) points = points + 1;
if (x2) points = points + 1;
if (x3) points = points + 1;
if (x4) points = points + 1;
if (x5) points = points + 1;
if (x6) points = points + 1;
if (x7) points = points + 1;
if (x8) points = points + 1;

Console.WriteLine(); Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("                  First look!                  ");
Console.WriteLine();
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn           : " + turn_number);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");
Console.WriteLine("                Board score : " + board_score);

board_score = (points * points);

while (round < 6)
{
    {
        turn_number = turn_number + 1;
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("             |------Round " + round + "------|");
        Console.WriteLine();
        Console.WriteLine("             #####################");
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     " + turn_number + "      &      " + turn);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : " + player_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : " + computer_score);
        Console.WriteLine("             ##                 ##");
        Console.WriteLine("             #####################");
        Console.WriteLine("                Board score : " + board_score);
    }
    if (board_score == 0)
    {
        Console.WriteLine(); Console.WriteLine("Please choose a move from 1 to 6");
        string hamle_numarası = (Console.ReadLine());

        if (hamle_numarası == "1")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n1; n1 = n3; n3 = n2; n2 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "2")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n4; n4 = n6; n6 = n5; n5 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "3")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n7; n7 = n9; n9 = n8; n8 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "4")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n1; n1 = n7; n7 = n4; n4 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "5")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n2; n2 = n8; n8 = n5; n5 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "6")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n3; n3 = n9; n9 = n6; n6 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else
        {
            Console.WriteLine("invalid move number"); turn_number = turn_number - 1;
            Console.WriteLine();
        }
        {
            if (board_score > 0)
            {
                if (kimin_sırası % 2 == 1) kimin_sırası = kimin_sırası + 1;
                if (kimin_sırası % 2 == 0) turn = "Player";
                else turn = "Computer";

                turn_number = 0;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             |------Round " + round + "------|");
                Console.WriteLine();
                Console.WriteLine("             #####################");
                Console.WriteLine("             ##                 ##");
                Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##");
                Console.WriteLine("             ##                 ##");
                Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##");
                Console.WriteLine("             ##                 ##");
                Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##");
                Console.WriteLine("             ##                 ##");
                Console.WriteLine("             #####################");

                Random random = new Random();

                n1 = random.Next(1, 10);
                do
                    n2 = random.Next(1, 10);
                while (n1 == n2);
                do
                    n3 = random.Next(1, 10);
                while (n1 == n3 | n2 == n3);
                do
                    n4 = random.Next(1, 10);
                while (n1 == n4 | n2 == n4 | n3 == n4);
                do
                    n5 = random.Next(1, 10);
                while (n1 == n5 | n2 == n5 | n3 == n5 | n4 == n5);
                do
                    n6 = random.Next(1, 10);
                while (n1 == n6 | n2 == n6 | n3 == n6 | n4 == n6 | n5 == n6);
                do
                    n7 = random.Next(1, 10);
                while (n1 == n7 | n2 == n7 | n3 == n7 | n4 == n7 | n5 == n7 | n6 == n7);
                do
                    n8 = random.Next(1, 10);
                while (n1 == n8 | n2 == n8 | n3 == n8 | n4 == n8 | n5 == n8 | n6 == n8 | n7 == n8);
                do
                    n9 = random.Next(1, 10);
                while (n1 == n9 | n2 == n9 | n3 == n9 | n4 == n9 | n5 == n9 | n6 == n9 | n7 == n9 | n8 == n9);

                if (kim_puan_aldı % 2 == 1) whowon = "Player";
                else whowon = "Computer";

                if (kim_puan_aldı % 2 == 1)
                    player_score = (player_score + board_score);
                else
                    computer_score = (computer_score + board_score);

                Thread.Sleep(1000);
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("              " + whowon + " won " + board_score + " point!"); Console.WriteLine();
                Console.WriteLine("             *********************                  ");
                Console.WriteLine("             *                   *");
                Console.WriteLine("             *    Round " + round + " End    *");
                Console.WriteLine("             *                   *");
                Console.WriteLine("             *********************                  "); Console.WriteLine();

                x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
                x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
                x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
                x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
                x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
                x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
                x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
                x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

                points = 0;
                board_score = 0;
                round = round + 1;
                kim_puan_aldı = 0;
                {
                    if (x1) points = points + 1;
                    if (x2) points = points + 1;
                    if (x3) points = points + 1;
                    if (x4) points = points + 1;
                    if (x5) points = points + 1;
                    if (x6) points = points + 1;
                    if (x7) points = points + 1;
                    if (x8) points = points + 1;
                }
                board_score = (points * points);
            }
            else Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine(); Console.WriteLine("Please choose a move from 1 to 6");
        string hamle_numarası = (Console.ReadLine());

        if (hamle_numarası == "1")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n1; n1 = n3; n3 = n2; n2 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "2")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n4; n4 = n6; n6 = n5; n5 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;

            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "3")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n7; n7 = n9; n9 = n8; n8 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "4")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n1; n1 = n7; n7 = n4; n4 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "5")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n2; n2 = n8; n8 = n5; n5 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else if (hamle_numarası == "6")
        {
            kimin_sırası = kimin_sırası + 1; kim_puan_aldı = kim_puan_aldı + 1;
            if (kimin_sırası % 2 == 0) turn = "Player";
            else turn = "Computer";
            temp = n3; n3 = n9; n9 = n6; n6 = temp;

            x1 = ((n1 + 2 == n2 + 1 && n2 + 1 == n3) | (n1 - 2 == n2 - 1 && n2 - 1 == n3));
            x2 = ((n4 + 2 == n5 + 1 && n5 + 1 == n6) | (n4 - 2 == n5 - 1 && n5 - 1 == n6));
            x3 = ((n7 + 2 == n8 + 1 && n8 + 1 == n9) | (n7 - 2 == n8 - 1 && n8 - 1 == n9));
            x4 = ((n1 + 2 == n4 + 1 && n4 + 1 == n7) | (n1 - 2 == n4 - 1 && n4 - 1 == n7));
            x5 = ((n2 + 2 == n5 + 1 && n5 + 1 == n8) | (n2 - 2 == n5 - 1 && n5 - 1 == n8));
            x6 = ((n3 + 2 == n6 + 1 && n6 + 1 == n9) | (n3 - 2 == n6 - 1 && n6 - 1 == n9));
            x7 = ((n1 + 2 == n5 + 1 && n5 + 1 == n9) | (n1 - 2 == n5 - 1 && n5 - 1 == n9));
            x8 = ((n3 + 2 == n5 + 1 && n5 + 1 == n7) | (n3 - 2 == n5 - 1 && n5 - 1 == n7));

            points = 0;
            board_score = 0;
            {
                if (x1) points = points + 1;
                if (x2) points = points + 1;
                if (x3) points = points + 1;
                if (x4) points = points + 1;
                if (x5) points = points + 1;
                if (x6) points = points + 1;
                if (x7) points = points + 1;
                if (x8) points = points + 1;
            }
            board_score = (points * points);
        }
        else
        {
            Console.WriteLine("invalid move number"); turn_number = turn_number - 1;
            Console.WriteLine();
        }
        if (board_score > 0) Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------"); Console.WriteLine();
Console.WriteLine("              ++++++++++++++++++++++"); Console.WriteLine();
Console.WriteLine("               Player's Point   : " + player_score); Console.WriteLine();
Console.WriteLine("               Computer's Point : " + computer_score); Console.WriteLine();
Console.WriteLine("              ++++++++++++++++++++++"); Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------"); Console.WriteLine();
{
    if (computer_score > player_score)
        Console.WriteLine("                      Computer WON");
    else if (computer_score < player_score)
        Console.WriteLine("                      Player WON");
    else
        Console.WriteLine("                      ENDED DRAW"); Console.WriteLine(""); Console.WriteLine();
}
