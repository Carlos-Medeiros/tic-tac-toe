// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Board board = new Board();

User player1 = new User();
player1.Score = 0;

User player2 = new User();
player2.Score = 0;

int position = 0;


Console.WriteLine("Bem vindo ao jogo da velha");

Console.Write("Jogador 1 digite seu nome: ");
player1.Name = Console.ReadLine();

Console.Write("Jogador 2 digite seu nome: ");
player2.Name = Console.ReadLine();

Console.Write("Jogador(a) " + player1.Name + " escolha entre X ou O: ");
player1.Choice = Console.ReadLine().ToUpper()[0];
    
if (player1.Choice != 'X' && player1.Choice != 'O')
{
    while (true)
    {
        Console.Write("Jogador(a) " + player1.Name + " escolha entre X ou O: ");
        player1.Choice = Console.ReadLine().ToUpper()[0];

        if (player1.Choice == 'X' || player1.Choice == 'O')
        {
            break;
        }
    }
}
if (player1.Choice == 'X')
{
    player2.Choice = 'O';
}
else
{
    player2.Choice = 'X';
}

Console.WriteLine("Jodador(a) " + player1.Name + " jogará com " + player1.Choice);
Console.WriteLine("Jodador(a) " + player2.Name + " jogará com " + player2.Choice);
Console.WriteLine("----------------------------------------------");


board.printGame();

while (true)
{


    Console.WriteLine("----------------------------------------------");
    Console.Write("Jogador(a) " + player1.Name + " escolha onde você deseja jogar: ");
    position = Convert.ToInt32(Console.ReadLine());

    if (position < 1 || position > 9)
    {
        while (true)
        {
            Console.Write("Jogador(a) " + player1.Name + " escolha onde você deseja jogar: ");
            position = Convert.ToInt32(Console.ReadLine());
            if (position >= 1 && position <= 9)
            {
                if (board.play(player1, position - 1))
                {
                    break;
                }
                else
                {
                    board.play(player1, position - 1);
                }
            }
        }
    }
    else
    {
        board.play(player1, position - 1);
    }

    if (board.win(player1))
    {
        player1.Score = player1.Score + 1;
        Console.WriteLine("Parabens ao jogador " + player1.Name + " pela vitória");
        Console.WriteLine("Placar: " + player1.Name + " Pontos: " + player1.Score + " | " + player2.Name + " Pontos: " + player2.Score);
        Console.WriteLine("----------------------------------------------");
        Console.Write("Deseja continuar jogando S | N ? ");
        char keepPlaying = Console.ReadLine().ToUpper()[0];
        if (keepPlaying == 'S')
        {
            board.resetGame();
            board.printGame();
        }
        else
        {
            break;
        }
    }

    Console.WriteLine("----------------------------------------------");
    Console.Write("Jogador(a) " + player2.Name + " escolha onde você deseja jogar: ");
    position = Convert.ToInt32(Console.ReadLine());

    if (position < 1 || position > 9)
    {
        while (true)
        {
            Console.Write("Jogador(a) " + player2.Name + " escolha onde você deseja jogar: ");
            position = Convert.ToInt32(Console.ReadLine());
            if (position >= 1 && position <= 9)
            {
                if (board.play(player2, position - 1))
                {
                    break;
                }
                else
                {
                    board.play(player2, position - 1);
                }

            }
        }
    }
    else
    {
        board.play(player2, position - 1);
    }

    if (board.win(player2))
    {
        player2.Score = player2.Score + 1;
        Console.WriteLine("Parabens ao jogador " + player2.Name + " pela vitória");
        Console.WriteLine("Placar: " + player1.Name + " Pontos: " + player1.Score + " | " + player2.Name + " Pontos: " + player2.Score);
        Console.WriteLine("----------------------------------------------");
        Console.Write("Deseja continuar jogando S | N ? ");
        char keepPlaying = Console.ReadLine().ToUpper()[0];
        if (keepPlaying == 'S')
        {
            board.resetGame();
            board.printGame();
        }
        else
        {
            break;
        }
    }
}

Console.WriteLine("Obrigado");

