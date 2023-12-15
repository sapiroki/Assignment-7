namespace Assignment_7
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
            btnGradeExam = new Button();
            panel1 = new Panel();
            incorrectlyAnsweredLabel = new Label();
            passingLabel = new Label();
            scoreLabel = new Label();
            label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGradeExam
            // 
            btnGradeExam.Location = new Point(104, 65);
            btnGradeExam.Name = "btnGradeExam";
            btnGradeExam.Size = new Size(136, 53);
            btnGradeExam.TabIndex = 0;
            btnGradeExam.Text = "Grade exam";
            btnGradeExam.UseVisualStyleBackColor = true;
            btnGradeExam.Click += btnGradeExam_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(incorrectlyAnsweredLabel);
            panel1.Controls.Add(passingLabel);
            panel1.Controls.Add(scoreLabel);
            panel1.Location = new Point(12, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 475);
            panel1.TabIndex = 1;
            // 
            // incorrectlyAnsweredLabel
            // 
            incorrectlyAnsweredLabel.AutoSize = true;
            incorrectlyAnsweredLabel.Location = new Point(16, 54);
            incorrectlyAnsweredLabel.Name = "incorrectlyAnsweredLabel";
            incorrectlyAnsweredLabel.Size = new Size(67, 20);
            incorrectlyAnsweredLabel.TabIndex = 2;
            incorrectlyAnsweredLabel.Text = "incorrect";
            incorrectlyAnsweredLabel.Visible = false;
            // 
            // passingLabel
            // 
            passingLabel.AutoSize = true;
            passingLabel.Location = new Point(16, 34);
            passingLabel.Name = "passingLabel";
            passingLabel.Size = new Size(59, 20);
            passingLabel.TabIndex = 1;
            passingLabel.Text = "passing";
            passingLabel.Visible = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(16, 14);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(44, 20);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "score";
            scoreLabel.Visible = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(29, 33);
            label.Name = "label";
            label.Size = new Size(275, 20);
            label.TabIndex = 2;
            label.Text = "Write your answers in an answers.txt file!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 611);
            Controls.Add(label);
            Controls.Add(panel1);
            Controls.Add(btnGradeExam);
            Name = "Form1";
            Text = "Exam grading";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGradeExam;
        private Panel panel1;
        private Label scoreLabel;
        private Label label;
        private Label passingLabel;
        private Label incorrectlyAnsweredLabel;
    }
}