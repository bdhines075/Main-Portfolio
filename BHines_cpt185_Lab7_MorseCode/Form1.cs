using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHines_cpt185_Lab7_MorseCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Brandon Hines*
         * CPT185*
         * Lab7*
         * Morse Code Converter*         
         */

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //user input and display output
            string input = txtInput.Text.ToUpper();//to upper for uniformity of conversion method to pick up letters
            txtOutput.Text = ConvertText(input);
        }

        
        //function to build the text
        private string ConvertText(string input)
        { string morseOutput = " ";
        
        foreach (char character in input)
            {
                morseOutput += ConvertCharacter(character) + " ";//calls convert function and adds a space after
            }
            return morseOutput.Trim();//returns converted text
        }
        //the conversion function
        private string ConvertCharacter(char character)
        {
            //switch statement to convert characters to morse code
            switch (character)
            {
                case 'A':
                    return ".-";
                case 'B':
                    return "-...";
                case 'C':
                    return "-.-.";
                case 'D':
                    return "-..";
                case 'E':
                    return ".";
                case 'F':
                    return "..-.";
                case 'G':
                    return "--.";
                case 'H':
                    return "....";
                case 'I':
                    return "..";
                case 'J':
                    return ".---";
                case 'K':
                    return "-.-";
                case 'L':
                    return ".-..";
                case 'M':
                    return "--";
                case 'N':
                    return "-.";
                case 'O':
                    return "---";
                case 'P':
                    return ".--.";
                case 'Q':
                    return "--.-";
                case 'R':
                    return ".-.";
                case 'S':
                    return "...";
                case 'T':
                    return "-";
                case 'U':
                    return "..-";
                case 'V':
                    return "...-";
                case 'W':
                    return ".--";
                case 'X':
                    return "-..-";
                case 'Y':
                    return "-.--";
                case 'Z':
                    return "--..";
                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                case '0':
                    return "-----";
                case ' ':
                    return "       ";//traditional 7 character gap for "space"
                case '.': 
                    return ".-.-.-";
                case ',':
                    return "--..--";
                case '?':
                    return "..--..";
                default:
                    return "#";//if unknown character is entered
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();//clears input
            txtOutput.Text = string.Empty;//clears output
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKey.Text = 
                  "A: .-       B: -...\n" +
                  "C: -.-.     D: -..\n" +
                  "E: .        F: ..-.\n" +
                  "G: --.      H: ....\n" +
                  "I: ..       J: .---\n" +
                  "K: -.-      L: .-..\n" +
                  "M: --       N: -.\n" +
                  "O: ---      P: .--.\n" +
                  "Q: --.-     R: .-.\n" +
                  "S: ...      T: -\n" +
                  "U: ..-      V: ...-\n" +
                  "W: .--      X: -..-\n" +
                  "Y: -.--     Z: --..\n" +
                  "1: .----    2: ..---\n" +
                  "3: ...--    4: ....-\n" +
                  "5: .....    6: -....\n" +
                  "7: --...    8: ---..\n" +
                  "9: ----.    0: -----\n" +
                  ".: .-.-.-   ,: --..--\n" +
                  "?: ..--..";


        }
    }
}
