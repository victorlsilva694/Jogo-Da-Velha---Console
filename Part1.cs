using System;

namespace ConsoleApp1
{
    class Part1
    {
        public string posicaoX;
        public string posicaoO;
        public string Escolha;
        public string Aa = "Aa";
        public string Bb = "Bb";
        public string Cc = "Cc";
        public string a_ = "a_";
        public string b_ = "b_";
        public string c_ = "c_";
        public string A_ = "A_";
        public string B_ = "B_";
        public string C_ = "C_";
        public int i;
        public int j;

        public void tabuleiro()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Aa}  |  {Bb}  |  {Cc}");
            Console.WriteLine($"-----|-----|-----");
            Console.WriteLine($"{a_}  |  {b_}  |  {c_}  ");
            Console.WriteLine($"-----|-----|-----");
            Console.WriteLine($"{A_}  |  {B_}  |  {C_}  ");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Você será X ou O ?");
            Escolha = Console.ReadLine();

            if (Escolha == "X")
            {
                for (i = 0; i <= 8; i++)
                {
                    Console.WriteLine("Em qual posição deseja jogar?");
                    posicaoX = Console.ReadLine();

                    if (posicaoX == "")
                    {
                        Console.WriteLine("Posição errada");
                    }
                    else
                    {
                        switch (posicaoX)
                        {
                            case "Aa":
                                Aa = "X";
                                break;
                            case "Bb":
                                Bb = "X";
                                break;
                            case "Cc":
                                Cc = "X";
                                break;
                            case "a_":
                                a_ = "X";
                                break;
                            case "b_":
                                b_ = "X";
                                break;
                            case "c_":
                                c_ = "X";
                                break;
                            case "A_":
                                A_ = "X";
                                break;
                            case "B_":
                                B_ = "X";
                                break;
                            case "C_":
                                C_ = "X";
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine($"{Aa}   |  {Bb}  |  {Cc}");
                        Console.WriteLine($"----|------|-----");
                        Console.WriteLine($"{a_}  |  {b_}  |  {c_}  ");
                        Console.WriteLine($"----|------|-----");
                        Console.WriteLine($"{A_}  |  {B_}  |  {C_}  ");
                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine("Agora é a vez do 'O' - Em qual posição irá jogar?");
                    posicaoO = Console.ReadLine();

                    if (posicaoO == "")
                    {
                        Console.WriteLine("Posição errada");
                    }
                    else
                    {
                        switch (posicaoO)
                        {
                            case "Aa":
                                Aa = "O";
                                break;
                            case "Bb":
                                Bb = "O";
                                break;
                            case "Cc":
                                Cc = "O";
                                break;
                            case "a_":
                                a_ = "O";
                                break;
                            case "b_":
                                b_ = "O";
                                break;
                            case "c_":
                                c_ = "O";
                                break;
                            case "A_":
                                A_ = "O";
                                break;
                            case "B_":
                                B_ = "O";
                                break;
                            case "C_":
                                C_ = "O";
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine($"{Aa}|{Bb}|{Cc}");
                        Console.WriteLine($"----|----|----");
                        Console.WriteLine($" {a_}|{b_}|{c_}");
                        Console.WriteLine($"----|----|----");
                        Console.WriteLine($"{A_}|{B_}|{C_}");
                        Console.WriteLine("------------------------------");
                    }
                }
            }

            /* Se o primeiro Jogador escolher o (O) */
            else if (Escolha == "O")
            {
                for (j = 0; j <= 8; j++)
                {
                    Console.WriteLine("Em qual posição deseja jogar?");
                    posicaoO = Console.ReadLine();

                    if (posicaoO == "")
                    {
                        Console.WriteLine("Posição errada");
                    }
                    else
                    {
                        switch (posicaoO)
                        {
                            case "Aa":
                                Aa = "O";
                                break;
                            case "Bb":
                                Bb = "O";
                                break;
                            case "Cc":
                                Cc = "O";
                                break;
                            case "a_":
                                a_ = "O";
                                break;
                            case "b_":
                                b_ = "O";
                                break;
                            case "c_":
                                c_ = "O";
                                break;
                            case "A_":
                                A_ = "O";
                                break;
                            case "B_":
                                B_ = "O";
                                break;
                            case "C_":
                                C_ = "O";
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine($"{Aa}  |  {Bb}  |  {Cc}");
                        Console.WriteLine($"-----|-----|-----");
                        Console.WriteLine($"{a_}  |  {b_}  |  {c_}  ");
                        Console.WriteLine($"-----|-----|-----");
                        Console.WriteLine($"{A_}  |  {B_}  |  {C_}  ");
                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine("Agora é a vez do 'X' - Em qual posição irá jogar?");
                    posicaoX = Console.ReadLine();

                    if (posicaoX == "")
                    {
                        Console.WriteLine("Posição errada");
                    }
                    else
                    {
                        switch (posicaoX)
                        {
                            case "Aa":
                                Aa = "X";
                                break;
                            case "Bb":
                                Bb = "X";
                                break;
                            case "Cc":
                                Cc = "X";
                                break;
                            case "a_":
                                a_ = "X";
                                break;
                            case "b_":
                                b_ = "X";
                                break;
                            case "c_":
                                c_ = "X";
                                break;
                            case "A_":
                                A_ = "X";
                                break;
                            case "B_":
                                B_ = "X";
                                break;
                            case "C_":
                                C_ = "X";
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine($"{Aa}  |  {Bb}  |  {Cc}");
                        Console.WriteLine($"-----|-----|-----");
                        Console.WriteLine($"{a_}  |  {b_}  |  {c_}  ");
                        Console.WriteLine($"-----|-----|-----");
                        Console.WriteLine($"{A_}  |  {B_}  |  {C_}  ");
                        Console.WriteLine("------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Escolha (X) ou (Y) e tente novamente");
            }
        }
    }
}
