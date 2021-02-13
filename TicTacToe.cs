using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyTicTacToe
{
    class Program
    {
        static int WonXincLoseO = 0, WonOincLoseX = 0,draws=0;
        static string StrWonXincLoseO =WonXincLoseO.ToString(), StrWonOincLoseX = WonOincLoseX.ToString(),StrDraws=draws.ToString();
        static string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string[] scoreX = new string[8] { "player", "won", "lose", "draws" ,"X",StrWonXincLoseO , StrWonOincLoseX, StrDraws  };
        static string[] scoreO = new string[8] { "player", "won", "lose", "draws","O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
        static void makeBoardAndScoring()
        {
            Console.WriteLine("\b");
            Console.WriteLine("-----------");
            Console.WriteLine("|{0} | {1} | {2} |",board[0],board[1],board[2]);
            Console.WriteLine("-----------");
            Console.WriteLine("|{0} | {1} | {2} | ", board[3], board[4], board[5]);
            Console.WriteLine("-----------");
            Console.WriteLine("|{0} | {1} | {2} |", board[6], board[7], board[8]);
            Console.WriteLine("-----------\n");

            Console.WriteLine("| {0} | {1} | {2} | {3}| ", scoreX[0], scoreX[1], scoreX[2], scoreX[3]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("|    {0}   |  {1}  |   {2}  |   {3}  | ", scoreX[4], scoreX[5], scoreX[6], scoreX[7]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("| {0} | {1} | {2} | {3}| ", scoreO[0], scoreO[1], scoreO[2], scoreO[3]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("|    {0}   |  {1}  |   {2}  |   {3}  | ", scoreO[4], scoreO[5], scoreO[6], scoreO[7]);
            Console.WriteLine("------------------------------\n");
        }
        static void Main(string[] args)
        {
            string errormessage = "you enter invalid position, please a number instead of a char\n";
            int o = 0, x = 0, turns = 0, placeX = 0, placeO = 0;
            List<int>arrayWinX= new List<int>();
            List<int>arrayWinO = new List<int>();
            string inputX = "", inputO = "", option = "";
            
            makeBoardAndScoring(); 
            do //when the game is active
            {
                for (int i = 0,j=i+1,k=j+1; i < 9; i=i+3,j=j+3,k=k+3)
                {
                    if (x == 3 && board[i] == "X" && board[j] == "X" && board[k] == "X")
                    {
                        WonXincLoseO++;
                        StrWonXincLoseO = WonXincLoseO.ToString();
                        Console.WriteLine("the x player has won,please press r and enter for restart the game\n");
                        Console.WriteLine("or please press q for end the game");
                        option = Console.ReadLine();
                        if (option=="r")
                        {
                            x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            scoreX = new string[8] { "playerx", "won", "lose", "draws", "", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                            scoreO = new string[8] { "playerO", "won", "lose", "draws", "", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                        }
                        if (option=="q")
                        {
                            break;
                        }
                           
                    }
                    if (o == 3 && board[i] == "O" && board[j] == "O" && board[k] == "O")
                    {
                        WonOincLoseX++;
                        StrWonOincLoseX = WonOincLoseX.ToString();
                        Console.WriteLine("the o player has won,please press r and enter for restart the game\n");
                        Console.WriteLine("or please press q for end the game");
                        option = Console.ReadLine();
                        if (option=="r")
                        {
                            x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                            scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                        }
                        if (option=="q")
                        {
                            break;
                        }  
                        
                    }
                }
                for (int i = 0, j = i + 3, k = j + 3; i < 3; i++, j++, k++)
                {
                    if (x == 3 && board[i] == "X" && board[j] == "X" && board[k] == "X")
                    {
                        WonXincLoseO++;
                        StrWonXincLoseO = WonXincLoseO.ToString();
                        Console.WriteLine("the x player has won,please press r and enter for restart the game\n");
                        Console.WriteLine("or please press q for end the game");
                        option = Console.ReadLine();
                        if (option=="r")
                        {
                            x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                            scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                        }
                        if (option=="q")
                        {
                            break;
                        }
                            
                    }
                    if (o == 3 && board[i] == "O" && board[j] == "O" && board[k] == "O")
                    {
                        WonOincLoseX++;
                        StrWonOincLoseX = WonOincLoseX.ToString();
                        Console.WriteLine("the o player has won,please press r and enter for restart the game\n");
                        Console.WriteLine("or please press q for end the game");
                        option = Console.ReadLine();
                        if (option=="r")
                        {
                            x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                            scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                        }
                        if (option=="q")
                        {
                            break;
                        }
                           
                    }
                }
                if (x == 3 && board[1-1] == "X" && board[5-1] == "X" && board[9-1] == "X" || board[3-1] == "X" && board[5-1] == "X" && board[7-1] == "X")
                {
                    WonXincLoseO++;
                    StrWonXincLoseO = WonXincLoseO.ToString();
                    Console.WriteLine("the x player has won,please press r and enter for restart the game\n");
                    Console.WriteLine("or please press q for end the game");
                    option = Console.ReadLine();
                    if (option=="r")
                    {
                        x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                        scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                    }
                    if (option=="q")
                    {
                        break;
                    }
                        
                }
                if (o == 3 && board[1-1] == "O" && board[5-1] == "O" && board[9-1] == "O" || board[3-1] == "O" && board[5-1] == "O" && board[7-1] == "O")
                {
                    WonOincLoseX++;
                    StrWonOincLoseX = WonOincLoseX.ToString();
                    Console.WriteLine("the o player has won,please press r and enter for restart the game\n");
                    Console.WriteLine("or please press q for end the game");
                    option = Console.ReadLine();
                    if (option=="r")
                    {
                        x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                        scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                    }
                    if(option=="q")
                    {
                        break;
                    }
                        
                }
                if (turns==9)
                {
                    draws++;
                    StrDraws = draws.ToString();
                    Console.WriteLine("the game ended with a tie,please press r and enter for restart the game\n");
                    Console.WriteLine("or please press q for end the game");
                    option = Console.ReadLine();
                    if (option=="r")
                    {
                        x = 0; o = 0; turns = 0; board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        scoreX = new string[8] { "player", "won", "lose", "draws", "X", StrWonXincLoseO, StrWonOincLoseX, StrDraws };
                        scoreO = new string[8] { "player", "won", "lose", "draws", "O", StrWonOincLoseX, StrWonXincLoseO, StrDraws };
                    }
                    if (option=="q")
                    {
                        break;
                    }
                       
                }
                if (turns % 2 == 0 && turns<10 )
                {
                    Console.WriteLine("choose number between 1 to 9,if space is free from O");
                    inputX = Console.ReadLine();
                   
                    int.TryParse(inputX, out placeX);
                    
                    if (placeX >= 1 && placeX <= 9 && board[placeX-1] != "O")
                    {
                        board[placeX - 1] = "X";
                        x++;
                        turns++;
                        makeBoardAndScoring();
                    }

                    else//not Numbers
                    {
                        Console.WriteLine(errormessage);
                    }
                }

                else if (turns % 2 != 0 && turns <10 )
                {
                    Console.WriteLine("choose number between 1 to 9,if space is free from X");
                    inputO = Console.ReadLine();
                    int.TryParse(inputO, out placeO);
                    
                    if (placeO >= 1 && placeO <= 9 && board[placeO-1] != "X")
                    {
                        board[placeO - 1] = "O";
                        o++;
                        turns++;
                        makeBoardAndScoring();
                    }
                    else//not Numbers
                    {
                        Console.WriteLine(errormessage);
                    }

                }
            } while (x != 3 || o != 3 || turns != 9);
            Thread.Sleep(200000);
        }
    }
}
