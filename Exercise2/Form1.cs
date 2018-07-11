using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardValidationTool
{
    public partial class LuhmForm : Form
    {
        public LuhmForm()
        {
            InitializeComponent();
        }

        // Event function: textEntryBox_TextChanged
        // Activates when the text entry box text changes.
        private void textEntryBox_TextChanged(object sender, EventArgs e)
        {
            ulong numberEntry = 0;
            string displayMessage = "Enter a card number!";
            bool exceptionThrown = false;
            correctedNumber.Text = "";

            try
            {
                numberEntry = Convert.ToUInt64(textEntryBox.Text);
            }
            catch(System.FormatException)
            {
                exceptionThrown = true;
            }

            if (exceptionThrown)    // If user did not enter a proper number.
            {
                pictureBox.Image = Properties.Resources.failure;
                displayMessage = "Not a valid card number!";
            }
            else if (!CardFunctions.is_correct_length(numberEntry))  // If card number is not correct length.
            {
                pictureBox.Image = Properties.Resources.failure;
                displayMessage = "Card number is not the correct length!";
            }
            else if (CardFunctions.luhn_check(numberEntry)) // If card number does not pass luhn's algorithm.
            {
                pictureBox.Image = Properties.Resources.failure;
                displayMessage = "Card number does not pass Luhn's Algorithm!";
                correctedNumber.Text = "*Corrected number: " + CardFunctions.get_corrected_number(numberEntry);
            }
            else   // Card number is valid.
            {
                pictureBox.Image = Properties.Resources.success;
                displayMessage = "This is a valid card number!";
            }

            titleLabel.Text = displayMessage;
        }
    }
}