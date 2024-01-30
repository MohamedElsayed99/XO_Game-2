namespace XO_Game
{
    partial class XO_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XO_Game));
            lbl_Name1 = new Label();
            txt_player1 = new TextBox();
            R_btn_X = new RadioButton();
            R_btn_O = new RadioButton();
            R_btn_O2 = new RadioButton();
            R_btn_X2 = new RadioButton();
            lbl_Name2 = new Label();
            txt_player2 = new TextBox();
            gb_player2 = new GroupBox();
            gb_player1 = new GroupBox();
            btn_startGame = new Button();
            lbl_top = new Label();
            gb_player2.SuspendLayout();
            gb_player1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Name1
            // 
            lbl_Name1.AutoSize = true;
            lbl_Name1.Location = new Point(6, 52);
            lbl_Name1.Name = "lbl_Name1";
            lbl_Name1.Size = new Size(94, 35);
            lbl_Name1.TabIndex = 10;
            lbl_Name1.Text = "Name";
            // 
            // txt_player1
            // 
            txt_player1.Location = new Point(6, 99);
            txt_player1.Margin = new Padding(3, 4, 3, 4);
            txt_player1.Name = "txt_player1";
            txt_player1.Size = new Size(291, 41);
            txt_player1.TabIndex = 8;
            txt_player1.TextChanged += txt_player1_TextChanged;
            // 
            // R_btn_X
            // 
            R_btn_X.AutoSize = true;
            R_btn_X.Location = new Point(115, 49);
            R_btn_X.Name = "R_btn_X";
            R_btn_X.Size = new Size(58, 39);
            R_btn_X.TabIndex = 16;
            R_btn_X.TabStop = true;
            R_btn_X.Text = "X";
            R_btn_X.UseVisualStyleBackColor = true;
            R_btn_X.CheckedChanged += R_btn_X_CheckedChanged;
            // 
            // R_btn_O
            // 
            R_btn_O.AutoSize = true;
            R_btn_O.Location = new Point(197, 48);
            R_btn_O.Name = "R_btn_O";
            R_btn_O.Size = new Size(57, 39);
            R_btn_O.TabIndex = 17;
            R_btn_O.TabStop = true;
            R_btn_O.Text = "O";
            R_btn_O.UseVisualStyleBackColor = true;
            R_btn_O.CheckedChanged += R_btn_O_CheckedChanged;
            // 
            // R_btn_O2
            // 
            R_btn_O2.AutoSize = true;
            R_btn_O2.Location = new Point(209, 52);
            R_btn_O2.Name = "R_btn_O2";
            R_btn_O2.Size = new Size(56, 39);
            R_btn_O2.TabIndex = 21;
            R_btn_O2.TabStop = true;
            R_btn_O2.Text = "O";
            R_btn_O2.UseVisualStyleBackColor = true;
            R_btn_O2.CheckedChanged += R_btn_O2_CheckedChanged;
            // 
            // R_btn_X2
            // 
            R_btn_X2.AutoSize = true;
            R_btn_X2.Location = new Point(126, 52);
            R_btn_X2.Name = "R_btn_X2";
            R_btn_X2.Size = new Size(57, 39);
            R_btn_X2.TabIndex = 20;
            R_btn_X2.TabStop = true;
            R_btn_X2.Text = "X";
            R_btn_X2.UseVisualStyleBackColor = true;
            R_btn_X2.CheckedChanged += R_btn_X2_CheckedChanged;
            // 
            // lbl_Name2
            // 
            lbl_Name2.AutoSize = true;
            lbl_Name2.Location = new Point(6, 52);
            lbl_Name2.Name = "lbl_Name2";
            lbl_Name2.Size = new Size(96, 35);
            lbl_Name2.TabIndex = 19;
            lbl_Name2.Text = "Name ";
            // 
            // txt_player2
            // 
            txt_player2.Location = new Point(6, 101);
            txt_player2.Margin = new Padding(3, 4, 3, 4);
            txt_player2.Name = "txt_player2";
            txt_player2.Size = new Size(285, 41);
            txt_player2.TabIndex = 18;
            txt_player2.TextChanged += txt_player2_TextChanged;
            // 
            // gb_player2
            // 
            gb_player2.BackColor = Color.Transparent;
            gb_player2.Controls.Add(txt_player2);
            gb_player2.Controls.Add(R_btn_O2);
            gb_player2.Controls.Add(lbl_Name2);
            gb_player2.Controls.Add(R_btn_X2);
            gb_player2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gb_player2.Location = new Point(435, 124);
            gb_player2.Name = "gb_player2";
            gb_player2.Size = new Size(297, 167);
            gb_player2.TabIndex = 22;
            gb_player2.TabStop = false;
            gb_player2.Text = "Player 2";
            gb_player2.Enter += gb_player2_Enter;
            // 
            // gb_player1
            // 
            gb_player1.BackColor = Color.Transparent;
            gb_player1.Controls.Add(txt_player1);
            gb_player1.Controls.Add(lbl_Name1);
            gb_player1.Controls.Add(R_btn_O);
            gb_player1.Controls.Add(R_btn_X);
            gb_player1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_player1.Location = new Point(48, 126);
            gb_player1.Name = "gb_player1";
            gb_player1.Size = new Size(303, 164);
            gb_player1.TabIndex = 23;
            gb_player1.TabStop = false;
            gb_player1.Text = "Player 1";
            gb_player1.Enter += gb_player1_Enter;
            // 
            // btn_startGame
            // 
            btn_startGame.BackColor = Color.GreenYellow;
            btn_startGame.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_startGame.Location = new Point(203, 356);
            btn_startGame.Margin = new Padding(3, 4, 3, 4);
            btn_startGame.Name = "btn_startGame";
            btn_startGame.Size = new Size(383, 69);
            btn_startGame.TabIndex = 24;
            btn_startGame.Text = "Start Game";
            btn_startGame.UseVisualStyleBackColor = false;
            btn_startGame.Click += btn_startGame_Click;
            // 
            // lbl_top
            // 
            lbl_top.BackColor = Color.Transparent;
            lbl_top.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_top.Location = new Point(255, 18);
            lbl_top.Name = "lbl_top";
            lbl_top.Size = new Size(266, 70);
            lbl_top.TabIndex = 25;
            lbl_top.Text = "XO_Game";
            // 
            // XO_Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_top);
            Controls.Add(btn_startGame);
            Controls.Add(gb_player1);
            Controls.Add(gb_player2);
            Name = "XO_Game";
            Text = "Form2";
            Load += Form2_Load;
            gb_player2.ResumeLayout(false);
            gb_player2.PerformLayout();
            gb_player1.ResumeLayout(false);
            gb_player1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Name1;
        public TextBox txt_player1;
        private RadioButton R_btn_X;
        private RadioButton R_btn_O;
        private RadioButton R_btn_O2;
        private RadioButton R_btn_X2;
        private Label lbl_Name2;
        public TextBox txt_player2;
        private GroupBox gb_player2;
        private GroupBox gb_player1;
        private Button btn_startGame;
        private Label lbl_top;
    }
}