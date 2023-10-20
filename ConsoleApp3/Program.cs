int n1, n2, n3, n4, n5, n6, n7, n8, n9,round, turn,player_score,computer_score;

n1 = 1; n2 = 2; n3 = 3; n4 = 4; n5 = 5; n6 = 6; n7 = 7; n8 = 8; n9 = 9;

Random xxv = new Random();
n1 = xxv.Next(1, 10);
n2 = xxv.Next(1, 10-n1);
n3 = xxv.Next(1,10-n1-n2);
n4 = xxv.Next(1,10-n1-n2-n3);
n5 = xxv.Next(1,10-n1-n2-n3-n4);
n6 = xxv.Next(1, 10 - n1 - n2 - n3 - n4 - n5);







turn = 1;
round = 1;
computer_score = 0; 
player_score = 0;

Console.WriteLine();
Console.WriteLine("             |------Round "+round+"------|");
Console.WriteLine();
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:    "+turn+"    /    Player");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : "+player_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : "+computer_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");

Console.ReadLine();
