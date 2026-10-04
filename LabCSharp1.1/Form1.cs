using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_KeyDown_1(object sender, KeyEventArgs e)
        {
            // If the enter key is pressed, read the input
            if (e.KeyCode == Keys.Enter)
            {
                string inputText = input.Text;
                // Try to cast the input to int
                try
                {
                    int number = int.Parse(inputText);
                    // Check for range
                    if (number < 1 || number > 10)
                    {
                        throw new ArgumentOutOfRangeException("number", "Number must be between 1 and 10.");
                    }
                    MessageBox.Show("You entered a number: " + number);
                    for(int i = 0; i < number; i++)
                    {
                        MyThread thread = new MyThread(i + 1);
                        threads.Add(thread);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                    MessageBox.Show("You entered: " + inputText);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Number must be between 1 and 10.");
                }
                input.Clear();
            }
        }
    }
}
