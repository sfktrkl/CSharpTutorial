using System.Windows.Forms;
using System.Drawing;
using System;

namespace CountingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            this.comboBoxDivisible.Items.AddRange(numbers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxStart.Text.Trim() == "" || this.textBoxEnd.Text.Trim() == "")
                MessageBox.Show("Fill the boxes");
            else if (this.comboBoxDivisible.SelectedIndex == -1)
                MessageBox.Show("Select divisible");
            else
            {
                textBoxNumbers.Clear();
                var controlCount = 1;
                var firstNumber = Convert.ToInt32(this.textBoxStart.Text);
                var secondNumber = Convert.ToInt32(this.textBoxEnd.Text);
                var divisibleNumber = Convert.ToInt32(this.comboBoxDivisible.SelectedItem);

                for (int i = firstNumber; i < secondNumber; i++)
                {
                    if (i % divisibleNumber == 0)
                    {
                        if (controlCount % 5 == 0)
                            textBoxNumbers.Text += Environment.NewLine;
                        textBoxNumbers.Text += i.ToString() + " ";
                        controlCount++;
                    }
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBlack.Checked)
                this.textBoxNumbers.ForeColor = Color.Black;
            else if (this.radioButtonRed.Checked)
                this.textBoxNumbers.ForeColor = Color.Red;
            else if (this.radioButtonGreen.Checked)
                this.textBoxNumbers.ForeColor = Color.Green;
            else if (this.radioButtonBlue.Checked)
                this.textBoxNumbers.ForeColor = Color.Blue;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNumbers.Font = new Font(this.textBoxNumbers.Font, FontStyle.Regular);
            if (this.checkBoxBold.Checked)
                this.textBoxNumbers.Font = new Font(this.textBoxNumbers.Font, this.textBoxNumbers.Font.Style | FontStyle.Bold);
            if (this.checkBoxItalic.Checked)
                this.textBoxNumbers.Font = new Font(this.textBoxNumbers.Font, this.textBoxNumbers.Font.Style | FontStyle.Italic);
        }
    }
}
