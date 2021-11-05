// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Skibets position er x,y
//int[,] shipPosition = new int[3,2];

int[,,] pos = new int[3, 4, 3]
{
    {
        { 15, 20, (int)ConsoleColor.DarkMagenta },
        { 3, 27 , (int)ConsoleColor.Black},
        { 8, 8, (int)ConsoleColor.Red },
        { 12, 25, (int)ConsoleColor.Yellow }
    },
    {
        { 10, 25, (int)ConsoleColor.DarkMagenta },
        { 13, 17 , (int)ConsoleColor.Black},
        { 2, 5, (int)ConsoleColor.Red },
        { 36, 12, (int)ConsoleColor.Yellow }
    },
    {
        { 10, 25, (int)ConsoleColor.DarkMagenta },
        { 13, 17 , (int)ConsoleColor.Black},
        { 2, 5, (int)ConsoleColor.Red },
        { 36, 12, (int)ConsoleColor.Yellow }
    }
};

for (int j = 0; j < pos.GetLength(0); j++)
{
    Console.ReadKey();
    switch (j)
    {
        case 0:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            break;
        case 1:
            Console.BackgroundColor = ConsoleColor.Cyan;
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Red;
            break;
    }
    Console.Clear();

    for (int i = 0; i < pos.GetLength(1); i++)
    {
        Console.SetCursorPosition(pos[j, i, 0], pos[j ,i, 1]);
        Console.ForegroundColor = (ConsoleColor)pos[j, i, 2];
        Console.Write("X");
    }
}

//int tgif = pos.GetLength(2);


//for (int i = 0; i < pos2.GetLength(0); i++)
//{
//    Console.SetCursorPosition(pos2[i, 0], pos2[i, 1]);
//    Console.ForegroundColor = (ConsoleColor)pos2[i, 2];
//    Console.Write("X");
//}

//Console.SetCursorPosition(pos[1,0], pos[1,1]);
//Console.ForegroundColor = (ConsoleColor)pos[1, 2];
//Console.Write("X");


Console.ReadKey();