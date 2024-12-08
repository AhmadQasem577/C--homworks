namespace CollageCourseTest
{
    partial class Main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label = new Label();
            answer = new TextBox();
            result = new Label();
            NewGame = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 24F);
            label.Location = new Point(43, 9);
            label.Name = "label";
            label.Size = new Size(583, 54);
            label.TabIndex = 1;
            label.Text = "guess the random number here";
            // 
            // answer
            // 
            answer.Font = new Font("Segoe UI", 24F);
            answer.Location = new Point(251, 81);
            answer.Name = "answer";
            answer.Size = new Size(163, 61);
            answer.TabIndex = 2;
            answer.KeyDown += answer_KeyDown;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 24F);
            result.Location = new Point(229, 165);
            result.Name = "result";
            result.Size = new Size(212, 54);
            result.TabIndex = 3;
            result.Text = "result here";
            // 
            // NewGame
            // 
            NewGame.Font = new Font("Segoe UI", 24F);
            NewGame.Location = new Point(174, 245);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(327, 62);
            NewGame.TabIndex = 4;
            NewGame.Text = "New Game!";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Click += NewGame_Click;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 250);
            ClientSize = new Size(685, 340);
            Controls.Add(NewGame);
            Controls.Add(result);
            Controls.Add(answer);
            Controls.Add(label);
            Name = "Main_form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label;
        private TextBox answer;
        private Label result;
        private Button NewGame;
    }
}
