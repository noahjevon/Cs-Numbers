using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Outputs prime numbers from user input
        private void btn_prime_Click(object sender, EventArgs e)
        {
            int input;
            List<int> primeList = new List<int>();

            if (int.TryParse(txt_entry.Text, out input))
            {
                var inputArray = input.ToString().Select(
                    t=>int.Parse(t.ToString())).ToArray();

                foreach (int i in inputArray)
                {
                    int number = Convert.ToInt32(i);
                    int primeResult = Check_Prime(number);

                    if (primeResult == 1)
                    {
                        primeList.Add(number);
                    }
                }
                lbl_output.ForeColor = System.Drawing.Color.Green;
                lbl_output.Text = "Prime numbers: " + String.Join(",", primeList);
            }
            else
            {
                lbl_output.ForeColor = System.Drawing.Color.Red;
                lbl_output.Text = "Input must be numeric";
            }
        }
        
        // Outputs odd and even numbers from user input
        private void btn_odd_even_Click(object sender, EventArgs e)
        {
            int input;
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            if (int.TryParse(txt_entry.Text, out input))
            {
                var inputArray = input.ToString().Select(
                    t=>int.Parse(t.ToString())).ToArray();

                foreach (int i in inputArray)
                {
                    if (i % 2 == 0)
                    {
                        oddList.Add(i);
                    }
                    else
                    {
                        evenList.Add(i);
                    }
                }
                lbl_output.ForeColor = System.Drawing.Color.Green;
                lbl_output.Text = "Odd numbers: " + String.Join(",", oddList) + 
                                  "\n" + "Even numbers: " + String.Join(",", evenList);
            }
            else
            {
                lbl_output.ForeColor = System.Drawing.Color.Red;
                lbl_output.Text = "Input must be numeric";
            }
        }
        
        // Checks if input is valid - WIP 
        private static int Check_Input(int input)
        {
            int i;
            return 0;
        }

        // Checks if numbers are prime. Takes number as input
        private static int Check_Prime(int number)  
        {  
            int i;  
            for (i = 2; i <= number - 1; i++)  
            {  
                if (number % i == 0)  
                {  
                    return 0;  
                }  
            }  
            if (i == number)  
            {  
                return 1;  
            }  
            return 0;  
        }
    }
}