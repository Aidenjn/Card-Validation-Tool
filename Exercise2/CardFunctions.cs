// Title: CardFunctions.cs
// Author: Aiden Nelson
// Date: 7/11/2018
// Description: Handy functions for handling credit card numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardValidationTool
{
    class CardFunctions
    {
        // Function: get_last_digit
        // Description: Returns the last digit of a given number.
        public static int get_last_digit(ulong num)
        {
            return Convert.ToInt32(num % 10);    // Get the last digit of the card number.
        }

        // Function: luhn_check
        // Description: Runs Luhn's algorithm on a given number.
        // Uses Functions: get_last_digit
        // Parameters: Number being tested.
        // Pre-Conditions: Positive integer input.
        // Post-Conditions: Bool output.
        // Return: false - passes algorithm, true - does not pass algorithm.
        public static bool luhn_check(ulong num)
        {
            int sum = 0;
            int checkDigit = CardFunctions.get_last_digit(num);
            int[] digits = num.ToString().Select(Convert.ToInt32).ToArray();    // Convert num into array of digits.
            int everyOtherNumber = 0;   // For tracking every other number.

            for (int i = digits.Length - 2; i >= 0; i--)    // Run through digits in reverse order, skipping the ending digit.
            {
                digits[i] -= 48;    // Convert char value to digit value.
                if (everyOtherNumber % 2 == 0)
                {
                    digits[i] *= 2;
                    if (digits[i] > 9)
                        digits[i] -= 9;
                }
                sum += digits[i];
                everyOtherNumber++;
            }
            digits[digits.Length - 1] -= 48;    // Convert check digit char value to digit value.

            // Number does not pass the test if the calculated check digit does not match the original last digit.
            if ((sum * 9) % 10 != checkDigit)
                return true;
            else
                return false;
        }

        // Function: get_corrected_number
        // Description: Runs Luhn's algorithm on a given number, and then returns the number with the proper check digit.
        // Uses Functions: get_last_digit
        // Parameters: Number being corrected.
        // Pre-Conditions: Positive integer input.
        // Post-Conditions: Number passes Luhn's algorithm.
        // Return: 
        public static ulong get_corrected_number(ulong num)
        {
            int sum = 0;
            int checkDigit = CardFunctions.get_last_digit(num);
            int[] digits = num.ToString().Select(Convert.ToInt32).ToArray();    // Convert num into array of digits.
            int everyOtherNumber = 0;   // For tracking every other number.

            for (int i = digits.Length - 2; i >= 0; i--)    // Run through digits in reverse order, skipping the ending digit.
            {
                digits[i] -= 48;    // Convert char value to digit value.
                if (everyOtherNumber % 2 == 0)
                {
                    digits[i] *= 2;
                    if (digits[i] > 9)
                        digits[i] -= 9;
                }
                sum += digits[i];
                everyOtherNumber++;
            }

            return num - Convert.ToUInt32(checkDigit) + Convert.ToUInt32(sum * 9) % 10; // Replace the last digit with the correct checkDigit.
        }

        // Function: is_corrrect_length
        // Description: Checks to see if the card number is the correct length.
        // Parameters: Number being tested.
        // Pre-Conditions: Positive integer input.
        // Post-Conditions: Output must be 0 or 1.
        // Return: 0 - Number is correct length, 1 - does not pass algorithm.
        public static bool is_correct_length(ulong num)
        {
            string numStr = num.ToString();

            if ((numStr[0] == '3') && (numStr.Length == 15))
                return true;
            else if (numStr.Length == 16)
                return true;
            else
                return false;
        }
    }
}