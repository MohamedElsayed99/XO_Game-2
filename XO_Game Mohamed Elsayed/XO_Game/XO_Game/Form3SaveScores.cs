using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class Form3SaveScores : Form
    {

        public Button [,] SaveScoresButton;
        public SqlConnection CON;
        public SqlDataAdapter Adapter;
        public DataTable DT;
        public int playerXWins ;
        public int playerOWins ; 
        public string labelPlayerX;
        public string labelPlayerO;
        public Form3SaveScores(string lable_playerX ,int playerX_wins, string lable_playerO , int playerO_wins)
        {
            this.labelPlayerX = lable_playerX;
            this.labelPlayerO= lable_playerO;
            this.playerXWins = playerX_wins;
            this.playerOWins = playerO_wins; 
            InitializeComponent();
            initializegame();
            CON = new SqlConnection("Server =.; DataBase = SaveScore; Trusted_Connection = True ; TrustServerCertificate = True");
            Adapter = new SqlDataAdapter();
            DT = new DataTable();
        }

        private void Form3SaveScores_Load(object sender, EventArgs e)
        {
           // SaveScoreButton_Click(object obj, EventArgs e);

        }
        public void initializegame()
        {
            Button saveScoreButton1 = new Button();
            saveScoreButton1.Text = "Saved Scores";
            saveScoreButton1.Size = new System.Drawing.Size(250, 60);
            saveScoreButton1.BackColor = System.Drawing.Color.LightYellow;
            saveScoreButton1.Font = new System.Drawing.Font("Arial", 20F);
            saveScoreButton1.Location = new System.Drawing.Point(300, 10);
            saveScoreButton1.Click += new EventHandler(SaveScoreButton_Click);
            Controls.Add(saveScoreButton1);
        }
        public void SaveScoreButton_Click( object sender, EventArgs e)
        {
            SqlCommand selectcmd = new SqlCommand("select*from savescores;",CON);
            Adapter.SelectCommand = selectcmd;
            Adapter.Fill(DT);
            dgv_saveScores.DataSource = DT;

            SaveGame();
            RefreshData();
        }
        public void SaveGame()
        {
            string insertCommand = "INSERT INTO savescores (playerXName,playerXScore, playerOName,playerOScore,Gamedate) VALUES (@PlayerxName,@playerxScore, @playeroName,@playeroScore,@time)";
            Adapter.InsertCommand = new SqlCommand(insertCommand, CON);
            DataTable Dt2 = new DataTable();
             Adapter.Fill(Dt2);
            Adapter.InsertCommand.Parameters.AddWithValue("@PlayerxName", labelPlayerX);
            Adapter.InsertCommand.Parameters.AddWithValue("@playerxScore", playerXWins);
            Adapter.InsertCommand.Parameters.AddWithValue("@playeroName", labelPlayerO);
            Adapter.InsertCommand.Parameters.AddWithValue("@playeroScore", playerOWins);
            Adapter.InsertCommand.Parameters.AddWithValue("@time", DateTime.Now);

            CON.Open();
            Adapter.InsertCommand.ExecuteNonQuery();
            CON.Close();
            //RefreshData();
        }
        private void RefreshData()
        {
            SqlCommand selectcmd = new SqlCommand("SELECT * FROM savescores;", CON);
            Adapter.SelectCommand = selectcmd;
            DT.Clear(); // Clear the existing data in the DataTable
            Adapter.Fill(DT);
            dgv_saveScores.DataSource = DT;
        }
    }
}
