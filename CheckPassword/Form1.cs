using System;
using System.Windows.Forms;

namespace CheckPassword
{
    public partial class Form1 : Form
    {
        private PasswordChecker.PasswordChecker _passwordChecker;

        public Form1()
        {
            _passwordChecker = new PasswordChecker.PasswordChecker("Dataset.txt");

            InitializeComponent();
        }

        private void CheckPassword(object sender, EventArgs e)
        {
            var res = _passwordChecker.Check(PasswordInput.Text);
            if (res > 0.33)
            {
                PasswordStatus.Text = "Надежный";
            }
            else if (res < -0.33)
            {
                PasswordStatus.Text = "Слабый";
            }
            else
            {
                PasswordStatus.Text = "Средний";
            }

            PasswordStatusPB.Value = (int)(++res * 50);
        }
    }
}
