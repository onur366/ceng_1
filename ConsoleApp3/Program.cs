int n1, n2, n3, n4, n5, n6, n7, n8, n9,round,turn,player_score,computer_score;

Console.WriteLine("Welcome to our game :D ");
Console.WriteLine();
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n4 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n5 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n6 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n7 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n8 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Choose a number between 1 to 9 without repetation!");
n9 = Convert.ToInt16(Console.ReadLine());


turn = 1;
round = 1;
computer_score = 0; 
player_score = 0;

Console.WriteLine();
Console.WriteLine("             |------Round "+round+"------|");
Console.WriteLine();
Console.WriteLine("             #####################");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n1 + "    " + n2 + "    " + n3 + "   ##      Turn:     "+turn+"    /    Player");
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n4 + "    " + n5 + "    " + n6 + "   ##      Player Score   : "+player_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             ##   " + n7 + "    " + n8 + "    " + n9 + "   ##      Computer Score : "+computer_score);
Console.WriteLine("             ##                 ##");
Console.WriteLine("             #####################");

Console.ReadLine();

