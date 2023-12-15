namespace Assignment_7
{
    public partial class Form1 : Form
    {
        private readonly string[] correctAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        private string[] studentAnswers;
        private int correctlyAnswered = 0;
        private int incorrectlyAnswered = 0;
        private bool passing;

        public Form1()
        {
            InitializeComponent();

            incorrectlyAnsweredLabel.Text = "Incorrectly answered questions:";
        }

        private void readStudentAnswers()
        {
            try
            {
                using (StreamReader reader = new StreamReader("answers.txt"))
                {
                    studentAnswers = new string[20];
                    for (int i = 0; i < 20; i++)
                    {
                        studentAnswers[i] = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading student answers: " + ex.Message);
            }
        }

        private void calculateScore()
        {
            correctlyAnswered = 0;
            incorrectlyAnswered = 0;

            for (int i = 0; i < 20; i++)
            {
                if (studentAnswers[i] == correctAnswers[i])
                {
                    correctlyAnswered++;
                }
                else
                {
                    incorrectlyAnswered++;
                }
            }
        }

        private void checkPassing()
        {
            passing = correctlyAnswered >= 15; 
        }

        private void btnGradeExam_Click(object sender, EventArgs e)
        {
            readStudentAnswers();
            calculateScore();
            checkPassing();

            scoreLabel.Visible = true;
            scoreLabel.Text = "Score: " + correctlyAnswered + "/" + 20;
            passingLabel.Visible = true;
            passingLabel.Text = passing ? "Passed" : "Failed";

            incorrectlyAnsweredLabel.Visible = true;
            incorrectlyAnsweredLabel.Text = "Incorrectly answered questions:\n";

            for (int i = 0; i < 20; i++)
            {
                if (studentAnswers[i] != correctAnswers[i])
                {
                    incorrectlyAnsweredLabel.Text += (i + 1) + ": " + studentAnswers[i] + "\n";
                }
            }
        }
    }
}

