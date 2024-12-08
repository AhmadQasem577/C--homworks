using System.ComponentModel;

namespace CollageCourseTest
{
    public partial class Main_form : Form
    {
        Random random = new Random();
        int l;
        public Main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            l = random.Next(0, 1001);
        }



        private void answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(answer.Text, out int userValue))
                {
                    if (userValue == l)
                    {
                        result.Text = "correct!";
                        this.BackColor = System.Drawing.Color.Green;
                    }
                    else if (Math.Abs(userValue - l) <= 20)
                    {
                        result.Text = "warm!";
                        this.BackColor = System.Drawing.Color.Orange;
                        answer.Text = "";
                    }
                    else
                    {
                        result.Text = "cold!";
                        this.BackColor = System.Drawing.Color.Blue;
                        answer.Text = "";
                    }
                }
                else
                {
                    // Handle invalid input
                    result.Text = "Please enter a valid number.";
                    this.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            l = random.Next(0, 1001);
            answer.Text = "";
        }
    }

}
