using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PolishNotationConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateCharacters().Item1)
                MessageBox.Show("You inserted " + ValidateCharacters().Item2 + " but only the following characters are permitted: 0123456789+–*/^%.");
            else if (!ValidateDigits().Item1)
                MessageBox.Show("You inserted " + ValidateDigits().Item2 + " but only 1 digit numers are permitted.");
            else 
            {
                Converter converter = new Converter(textBoxInfix.Text);
                labelPostfix.Text = converter.ConvertPostfix();
            }
        }

        private (bool, string) ValidateDigits()
        {
            bool result = true;

            string value = textBoxInfix.Text;

            string numerError = "";

            List<string> digits = value.Split('+', '(', ')', '–', '*', '/', '^', '%').ToList();

            for (int i = 0; i < digits.Count; i++)
                if (digits[i].Count() > 1)
                {
                    result = false;
                    numerError = digits[i].ToString();
                }
            return (result, numerError);
        }

        private (bool, string) ValidateCharacters()
        {
            bool result = true;

            string permitted = "0123456789+–*/^%()";

            string digitError = "";

            foreach (char c in textBoxInfix.Text)
                if (!permitted.Contains(c))
                {
                    result = false;
                    digitError = c.ToString();

                    if (digitError == " ")
                        digitError = "a space";
                }
            return (result, digitError);

        }
    }
}
