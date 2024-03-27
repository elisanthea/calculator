using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Calculator : Form
    {
        double value1;
        double value2;
        double result = 0;
        string sign;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center; // Horizontal alignment
            textBox1.Multiline = true; // Enable multiline mode
            textBox1.AcceptsReturn = true; // Allow the text to wrap to the next line if it's too long
            textBox1.WordWrap = true; // Wrap words to the next line if needed
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "+";
                label1.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input.Please eneter a valid number.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "-";
                label1.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input.Please eneter a valid number.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "*";
                label1.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "/";
                label1.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value2))
            {
                label2.Text = textBox1.Text;
                switch (sign)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        if (value2 != 0)
                        {
                            result = value1 / value2;
                        }
                        else
                        {
                            MessageBox.Show("Division by zero is not allowed.");
                            return;
                        }
                        break;
                    case "%":
                        result = value1 % value2;
                        break;
                }
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "%";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple; // Change this color as needed
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red; // Change this color as needed
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Purple; // Change this color as needed
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Purple; // Change this color as needed
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Purple; // Change this color as needed
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.Purple; // Change this color as needed
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Purple; // Change this color as needed
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red; // Change this color as needed
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.Purple; // Change this color as needed
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.Purple; // Change this color as needed
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.Purple; // Change this color as needed
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red; // Change this color as needed
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green; // Change this color as needed
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.Purple; // Change this color as needed
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.Purple; // Change this color as needed
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red; // Change this color as needed
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackColor = Color.Red; // Change this color as needed
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackColor = Color.Green; // Change this color as needed
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = SystemColors.Control; // Change this to the original color of the button
        }

    }
    

}
