using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using Button = System.Windows.Forms.Button;

namespace WinFormsTicTacToe
{

    public partial class Form1 : Form
    {
        private static int num_games;
        private static int secondsRound;
        Random r = new Random();
        private string human = "X";
        private string ai = "O";
        private string[,] board = new string[3,3];
       

        public Form1()
        {
            InitializeComponent();
        }

        //Restarts a new game of Tic Tac Toe
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeBoard();
        }

        //Initializes the board with empty enabled buttons
        private void MakeBoard()
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    (c as Button).Enabled = true;
                    (c as Button).Text = "";
                }
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
                catch
                { }
            }
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    board[i, j] = "";
                }
            }
        }

        //Used to test the minimax algorithm
        private void PrintBoard()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Debug.Write("|" + board[i,j]);
                }
                Debug.WriteLine("|");
            }
        }

        //Returns the number of open spaces on the board
        private int NumEmpty(string[,] board)
        {
            var numAvail = 0;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                    {
                        numAvail++;
                    }
                }
            }
            return numAvail;
        }

        //Plays a game of tic tac toe with two computer players
        //using the Minimax algorithm
        private void Play(string[,] board, string p1, string p2)
        {
            string letter = "X";
            while (NumEmpty(board) != 0)
            {
                if (letter.Equals("X"))
                {
                    FindBestMove(p1);
                    PrintBoard();
                }
                else
                {
                    FindBestMove(p2);
                    PrintBoard();

                }
                string winner = CheckIfWinner();
                if (winner != null)
                {
                    if (winner.Equals(p1))
                    {
                        Debug.WriteLine(p1 + " won");
                        MessageBox.Show(p1 + "won!");
                    }
                    else if (winner.Equals(p2))
                    {
                        Debug.WriteLine(p2 + " won");
                        MessageBox.Show(p2 + "won!");
                    }
                    else
                    {
                        MessageBox.Show("It's a tie!");

                    }
                }
                if (letter.Equals("X"))
                {
                    letter = "O";
                }
                else
                {
                    letter = "X";
                }
                Thread.Sleep(secondsRound * 1000);
            }
        }

        //Sets the number of games and seconds between turns for AI v AI games
        public void SetAIvAI(string numGames, string seconds)
        {
            try
            {
                num_games = int.Parse(numGames);
                secondsRound = int.Parse(seconds);
            }
            catch
            {
            }
        }

        //Closes the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Takes a row and column and sets the corresponding button
        //to that player's mark
        private void rowColConvert(int row, int col, string type)
        {
            Button b = null;
            switch (row, col)
            {
                case (0, 0):
                    b = A1;
                    break;
                case (0, 1):
                    b = A2;
                    break;
                case (0, 2):
                    b = A3;
                    break;
                case (1, 0):
                    b = B1;
                    break;
                case (1, 1):
                    b = B2;
                    break;
                case (1, 2):
                    b = B3;
                    break;
                case (2, 0):
                    b = C1;
                    break;
                case (2, 1):
                    b = C2;
                    break;
                case (2, 2):
                    b = C3;
                    break;
            }
            b.Text = type;
            b.Enabled = false;
        }

        //Uses the Minimax algorithm to find the optimal next move in tic tac toe
        private void FindBestMove(string type)
        {
            if (NumEmpty(board) == 9)
            {
                Debug.WriteLine("The board is empty");
                int row = r.Next(0, 3);
                int col = r.Next(0, 3);
                board[row, col] = type;
                rowColConvert(row, col, type);
            }
            else
            {
                var row = -1;
                var col = -1;
                var bestScore = int.MinValue;
                string otherPlayer = null;
                if (type.Equals("X"))
                {
                    otherPlayer = "O";
                }
                else
                {
                    otherPlayer = "X";
                }
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        //is this spot open?
                        if (string.IsNullOrEmpty(board[i, j]))
                        {
                            //make the move and find minimax score
                            board[i, j] = type;
                            int score = 0;
                            score = MiniMax(board, type, otherPlayer);
                            //unmake move
                            board[i, j] = "";
                            if (score > bestScore)
                            {
                                bestScore = score;
                                row = i;
                                col = j;
                            }
                        }
                    }
                }
                board[row, col] = type;
                rowColConvert(row, col, type);
            }
        }

        //AI uses the MiniMax algorithm to guarantee a win or tie
        private int MiniMax(string[,] board, string ogPlayer, string player)
        {
            string maxPlayer = ogPlayer;
            string otherPlayer = null;
            if (player.Equals("X"))
            {
                otherPlayer = "O";
            }
            else
            {
                otherPlayer = "X";
            }
            string winner = null;
            winner = CheckIfWinner();    
            if (winner != null)
            {
                if (winner.Equals(otherPlayer) && otherPlayer.Equals(maxPlayer))
                {
                    return 10;
                }
                else if (winner.Equals(otherPlayer) && !otherPlayer.Equals(maxPlayer))
                {
                    return -10;
                }
                else
                {
                    //tie
                    return 0;
                }
            }
            if (player.Equals(maxPlayer))
            {
                var bestScore = int.MinValue;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (string.IsNullOrEmpty(board[i, j]))
                        {

                            board[i, j] = player;
                            var score = MiniMax(board, ogPlayer, otherPlayer);
                            board[i, j] = "";
                            bestScore = Math.Max(score, bestScore);
                        }
                    }
                }

                return bestScore;
            }
            else
            {
                var bestScore = int.MaxValue;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (string.IsNullOrEmpty(board[i, j]))
                        {

                            board[i, j] = player;
                            var score = MiniMax(board, ogPlayer, otherPlayer);
                            board[i, j] = "";
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
        }


        //Handles logic for a player turn
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string name = b.Name;
            b.Text = "X";
            switch (name)
            {
                case "A1":
                    board[0, 0] = human;
                    break;
                case "A2":
                    board[0, 1] = human;
                    break;
                case "A3":
                    board[0, 2] = human;
                    break;
                case "B1":
                    board[1, 0] = human;
                    break;
                case "B2":
                    board[1, 1] = human;
                    break;
                case "B3":
                    board[1, 2] = human;
                    break;
                case "C1":
                    board[2, 0] = human;
                    break;
                case "C2":
                    board[2, 1] = human;
                    break;
                case "C3":
                    board[2, 2] = human;
                    break;
            }
            b.Enabled = false;
            string winner = null;
            winner = CheckIfWinner();
            if (winner != null)
            {
                PrintEndGame(winner);
            }
            else
            {
                FindBestMove(ai);
                winner = CheckIfWinner();
                if (winner != null)
                {
                    PrintEndGame(winner);
                }
            }
        }

        //Disables all buttons when a game ends
        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch
            { }
        }

        //Returns if the strings given are all the same
        private bool AllEqual(string a, string b, string c)
        {
            return !string.IsNullOrEmpty(a) && a.Equals(b) && b.Equals(c);
        }

        //Determines if someone has won the game
        private string CheckIfWinner()
        {
            string winner = null;
            //check for horizontal winner
            for (var i = 0; i < 3; i++)
            {
                if (AllEqual(board[i, 0], board[i, 1], board[i, 2]))
                {
                    winner = board[i, 0];
                   
                }
            }
            //check for vertical winner
            for (var i = 0; i < 3; i++)
            {
                if (AllEqual(board[0, i], board[1, i], board[2, i]))
                {
                   winner = board[0, i];
                   
                }
            }
            //check for diagonal winner
            if (AllEqual(board[0, 0], board[1, 1], board[2, 2]))
            {
                winner = board[0, 0];
   
            }
            if (AllEqual(board[0, 2], board[1, 1], board[2, 0]))
            {
                winner = board[0, 2];
              
            }
            var numAvail = 0;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                    {
                        numAvail++;
                    }
                }
            }
            if (numAvail == 0 && winner == null)
            {
                return "tie";
            }
            return winner;
        }

        //Prints the result of the game 
        private void PrintEndGame(string endType)
        {
            DisableButtons();
            if (endType.Equals("tie"))
            {
                MessageBox.Show("It's a tie!");
            }
            else
            {
                MessageBox.Show(endType + " wins!");
            }
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    board[i, j] = "";
                }
            }
        }

        //Allows a user to watch the AI play against itself
        private void computerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
            for (int i = 0; i < num_games; i++)
            {
                MakeBoard();
                Play(board, "X", "O");
            }
            
        }
    }
}