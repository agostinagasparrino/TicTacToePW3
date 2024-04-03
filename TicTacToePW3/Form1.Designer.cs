namespace TicTacToePW3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 45);
            button1.Name = "button1";
            button1.Size = new Size(93, 93);
            button1.TabIndex = 14;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(144, 45);
            button2.Name = "button2";
            button2.Size = new Size(93, 93);
            button2.TabIndex = 15;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(243, 45);
            button3.Name = "button3";
            button3.Size = new Size(93, 93);
            button3.TabIndex = 16;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(45, 144);
            button4.Name = "button4";
            button4.Size = new Size(93, 93);
            button4.TabIndex = 17;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(144, 144);
            button5.Name = "button5";
            button5.Size = new Size(93, 93);
            button5.TabIndex = 18;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveBorder;
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(243, 144);
            button6.Name = "button6";
            button6.Size = new Size(93, 93);
            button6.TabIndex = 19;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(45, 243);
            button7.Name = "button7";
            button7.Size = new Size(93, 93);
            button7.TabIndex = 20;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveBorder;
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(144, 243);
            button9.Name = "button9";
            button9.Size = new Size(93, 93);
            button9.TabIndex = 21;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveBorder;
            button10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(243, 243);
            button10.Name = "button10";
            button10.Size = new Size(93, 93);
            button10.TabIndex = 22;
            button10.Text = "?";
            button10.UseVisualStyleBackColor = false;
            button10.Click += PlayerClickButton;
            // 
            // button11
            // 
            button11.ForeColor = Color.Maroon;
            button11.Location = new Point(136, 353);
            button11.Name = "button11";
            button11.Size = new Size(107, 23);
            button11.TabIndex = 23;
            button11.Text = "Restart Game";
            button11.UseVisualStyleBackColor = true;
            button11.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 386);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "TicTacToe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button8;
        private Button button14;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
        private System.Windows.Forms.Timer CPUTimer;
    }
}
