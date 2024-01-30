namespace XO_Game
{
    partial class Form3SaveScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3SaveScores));
            dgv_saveScores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_saveScores).BeginInit();
            SuspendLayout();
            // 
            // dgv_saveScores
            // 
            dgv_saveScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_saveScores.Location = new Point(4, 92);
            dgv_saveScores.Name = "dgv_saveScores";
            dgv_saveScores.RowHeadersWidth = 51;
            dgv_saveScores.Size = new Size(793, 355);
            dgv_saveScores.TabIndex = 0;
            // 
            // Form3SaveScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_saveScores);
            Name = "Form3SaveScores";
            Text = "Form3SaveScores";
            Load += Form3SaveScores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_saveScores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_saveScores;
    }
}