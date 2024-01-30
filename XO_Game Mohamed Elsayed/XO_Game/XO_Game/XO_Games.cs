using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace XO_Game
{
    public partial class XO_Games : Form
    {
        private Button[,] buttons;
        private bool playerXturn = true;
        public int playerXWins = 0;
        public int playerOWins = 0;
        public string playerXName = "Player X";
        public string playerOName = "Player O";
        public Label labelPlayerX;
        public Label labelPlayerO;
        public Label labelPlayerXcount;
        public Label labelPlayerOcount;
        public Label labelXO_Game;
        public int PlayerXcount;
        public int PlayerOcount;
        public string playerXname;
        public string playerOname;
        public bool IsPlayer1SelectedX;
        public bool IsPlayer2SelectedX;


        public XO_Games(string playerXname, string playerOname, bool isPlayer1SelectedX, bool isPlayer2SelectedX)
        {
             IsPlayer1SelectedX = isPlayer1SelectedX;
             IsPlayer2SelectedX = isPlayer2SelectedX;

            InitializeGameBoard();
            InitializeComponent();
            InitializeComponent2();
            InitializeLabels(playerXname, playerOname, isPlayer1SelectedX, isPlayer2SelectedX);

        }
        public void InitializeComponent2()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO_Game";
            this.ResumeLayout(false);
        }


        public void InitializeGameBoard()
        {
            buttons = new Button[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new System.Drawing.Size(60, 60);
                    buttons[i, j].BackColor = Color.LightYellow;
                    buttons[i, j].Location = new System.Drawing.Point(30 + (i * 70), 70 + (j * 70));
                    buttons[i, j].Font = new System.Drawing.Font("Showcard Gothic", 60F);
                    buttons[i, j].Tag = new Tuple<int, int>(i, j);
                    buttons[i, j].Click += new EventHandler(Button_Click);
                    Controls.Add(buttons[i, j]);
                }
            }

            // Add buttons

            Button resetButton = new Button();
            resetButton.Text = "Reset";
            resetButton.Size = new System.Drawing.Size(150, 35);
            resetButton.BackColor = System.Drawing.Color.Crimson;
            resetButton.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            resetButton.Location = new System.Drawing.Point(350, 140);
            resetButton.Click += new EventHandler(ResetButton_Click);
            Controls.Add(resetButton);

            Button newGameButton = new Button();
            newGameButton.Text = "New Game";
            newGameButton.Size = new System.Drawing.Size(150, 35);
            newGameButton.BackColor = System.Drawing.Color.GreenYellow;
            newGameButton.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            newGameButton.Location = new System.Drawing.Point(350, 180);
            newGameButton.Click += new EventHandler(NewGameButton_Click);
            Controls.Add(newGameButton);

            Button saveScoreButton = new Button();
            saveScoreButton.Text = "Saved Scores";
            saveScoreButton.Size = new System.Drawing.Size(150, 35);
            saveScoreButton.BackColor = System.Drawing.Color.GreenYellow;
            saveScoreButton.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            saveScoreButton.Location = new System.Drawing.Point(350, 220);
            saveScoreButton.Click += new EventHandler(SaveScoreButton_Click);
            Controls.Add(saveScoreButton);

        }

        public void InitializeLabels(string playerXname, string playerOname, bool isPlayer1SelectedX, bool isPlayer2SelectedX)
        {
            this.playerXname = playerXname;
            this.playerOname = playerOname;
            labelPlayerX = new Label();
            labelPlayerX.Text = $"Player 1 ( {(isPlayer1SelectedX ? "X" : "O")} ) : {playerXname}";
            labelPlayerX.BackColor = System.Drawing.Color.Transparent;
            labelPlayerX.Font = new System.Drawing.Font("Showcard Gothic", 20f);
            labelPlayerX.Location = new System.Drawing.Point(600, 150);
            labelPlayerX.AutoSize = true;
            Controls.Add(labelPlayerX);

            labelPlayerO = new Label();
            labelPlayerO.Text = $"Player 2 ( {(isPlayer2SelectedX ? "X" : "O")} ) : {playerOname} ";
            labelPlayerO.BackColor = System.Drawing.Color.Transparent;
            labelPlayerO.Font = new System.Drawing.Font("Showcard Gothic", 20f);
            labelPlayerO.Location = new System.Drawing.Point(600, 200);
            labelPlayerO.AutoSize = true;
            Controls.Add(labelPlayerO);

            labelPlayerXcount = new Label();
            labelPlayerXcount.Text = $"{PlayerXcount}";
            labelPlayerXcount.BackColor = System.Drawing.Color.Transparent;
            labelPlayerXcount.Font = new System.Drawing.Font("Showcard Gothic", 20f);
            labelPlayerXcount.Location = new System.Drawing.Point(1070, 150);
            labelPlayerXcount.AutoSize = true;
            Controls.Add(labelPlayerXcount);

            labelPlayerOcount = new Label();
            labelPlayerOcount.Text = $"{PlayerOcount}";
            labelPlayerOcount.BackColor = System.Drawing.Color.Transparent;
            labelPlayerOcount.Font = new System.Drawing.Font("Showcard Gothic", 20f);
            labelPlayerOcount.Location = new System.Drawing.Point(1070, 190);
            labelPlayerOcount.AutoSize = true;
            Controls.Add(labelPlayerOcount);

            labelXO_Game = new Label();
            labelXO_Game.Text = $"XO_Game";
            labelXO_Game.BackColor = System.Drawing.Color.Transparent;
            labelXO_Game.Font = new System.Drawing.Font("Showcard Gothic", 40f);
            labelXO_Game.Location = new System.Drawing.Point(450, 10);
            labelXO_Game.AutoSize = true;
            Controls.Add(labelXO_Game);

        }
        /*        public void Button_Click(object sender, EventArgs e)
                {
                    Button button = (Button)sender;
                    Tuple<int, int> position = (Tuple<int, int>)button.Tag;

                    if (button.Text == "")
                    {
                        if (playerXturn)
                        {
                            button.Text = "X";
                            if (CheckForWinner(position.Item1, position.Item2))
                            {
                                MessageBox.Show($"{labelPlayerX.Text} wins!");
                                labelPlayerXcount.Text = $"{PlayerXcount = PlayerXcount + 1}";
                                UpdateScore();
                                ResetGameBoard();
                            }
                            else if (IsBoardFull())
                            {
                                MessageBox.Show("It's a draw!");
                                ResetGameBoard();
                            }
                            playerXturn = false;
                        }
                        else
                        {
                            button.Text = "O";
                            if (CheckForWinner(position.Item1, position.Item2))
                            {
                                MessageBox.Show($"{labelPlayerO.Text} wins!");
                                labelPlayerOcount.Text = $"{PlayerOcount = PlayerOcount + 1}";
                                UpdateScore();
                                ResetGameBoard();
                            }
                            else if (IsBoardFull())
                            {
                                MessageBox.Show("It's a draw!");
                                ResetGameBoard();
                            }
                            playerXturn = true;
                        }

                        *//*playerXturn = !playerXturn;

                        if (CheckForWinner(position.Item1, position.Item2))
                        {
                            //playerXturn = !playerXturn;
                            MessageBox.Show($"{GetPlayerName()} wins!");
                            UpdateScore();
                            ResetGameBoard();
                        }
                        else if (IsBoardFull())
                        {
                            MessageBox.Show("It's a draw!");
                            ResetGameBoard();
                        }*//*

                    }
                }
        */

        public void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tuple<int, int> position = (Tuple<int, int>)button.Tag;

            if (button.Text == "")
            {

                if (playerXturn)
                {
                    button.Text = "X";
                    if (CheckForWinner(position.Item1, position.Item2))
                    {
                        MessageBox.Show($"{labelPlayerX.Text} wins!");
                        labelPlayerXcount.Text = $"{PlayerXcount = PlayerXcount + 1}";
                        UpdateScore();
                        ResetGameBoard();
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!");
                        ResetGameBoard();
                    }
                    playerXturn = false;
                }
                else
                {
                    button.Text = "O";
                    if (CheckForWinner(position.Item1, position.Item2))
                    {
                        MessageBox.Show($"{labelPlayerO.Text} wins!");
                        labelPlayerOcount.Text = $"{PlayerOcount = PlayerOcount + 1}";
                        UpdateScore();
                        ResetGameBoard();
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!");
                        ResetGameBoard();
                    }
                    playerXturn = true;
                }
            }
        }

        public string GetPlayerName()
        {
            return playerXturn ? (IsPlayer1SelectedX ? playerXName : playerOName) : (IsPlayer2SelectedX ? playerOName : playerXName);

            //return playerXturn ? playerXName : playerOName;/*labelPlayerX.Text : labelPlayerO.Text;*/
        }

        /*public void UpdateScore()
        {
            if (GetPlayerName() == labelPlayerX.Text)
                playerXWins++;
            else
                playerOWins++;
        }*/
        public void UpdateScore()
        {
            if (playerXturn)
                playerXWins++;
            else
                playerOWins++;

            labelPlayerXcount.Text = $"{playerXWins}";
            labelPlayerOcount.Text = $"{playerOWins}";
        }

        public bool CheckForWinner(int row, int col)
        {
            // row
            if (buttons[row, 0].Text == buttons[row, 1].Text && buttons[row, 1].Text == buttons[row, 2].Text && buttons[row, 0].Text != "")
                return true;

            // column
            if (buttons[0, col].Text == buttons[1, col].Text && buttons[1, col].Text == buttons[2, col].Text && buttons[0, col].Text != "")
                return true;

            // diagonals
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
                return true;

            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text && buttons[0, 2].Text != "")
                return true;

            return false;
        }

        public bool IsBoardFull()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                    return false;
            }
            return true;
        }

        public void ResetGameBoard()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
            }
            playerXturn = true;
        }

        public void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGameBoard();
        }

        public void NewGameButton_Click(object sender, EventArgs e)
        {
            ResetGameBoard();
            playerXWins = 0;
            playerOWins = 0;
            labelPlayerXcount.Text = $"{PlayerXcount = 0}";
            labelPlayerOcount.Text = $"{PlayerOcount = 0}";
            //resetLabels();
        }

        public void SaveScoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form3SaveScores form3SaveScores = new Form3SaveScores(labelPlayerX.Text, playerXWins, labelPlayerO.Text, playerOWins);
            Form3SaveScores form3SaveScores = new Form3SaveScores(playerXname, playerXWins, playerOname, playerOWins);
            form3SaveScores.ShowDialog();
        }
        public void resetLabels()
        {
            labelPlayerX.Text = $"Player X : {playerXName} ";
            labelPlayerO.Text = $"Player O : {playerOName} ";
        }

        private void XO_Games_Load(object sender, EventArgs e)
        {

        }
    }

}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

