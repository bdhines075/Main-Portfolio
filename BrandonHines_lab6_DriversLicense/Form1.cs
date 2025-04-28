using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrandonHines_lab6_DriversLicense
{
    public partial class Form1 : Form
    {
        // Answer array
        private char[] correctAnswers =
        {
            'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
            'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A'
        };

        private char[] studentAnswers;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadAnswers_Click(object sender, EventArgs e)
        {
            // Have user load file
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    studentAnswers = LoadAnswersFromFile(fileDialog.FileName); // Store answers
                    if (studentAnswers != null)
                    {
                        var gradingResults = EvaluateExam(studentAnswers); // Automatically grade the exam
                        ShowResults(gradingResults); // Display results in the textbox
                    }
                }
            }
        }

        // Read file
        private char[] LoadAnswersFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                return ConvertLinesToAnswers(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Convert to match up answers
        private char[] ConvertLinesToAnswers(string[] lines)
        {
            char[] answers = new char[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                answers[i] = char.ToUpper(lines[i][0]);
            }
            return answers;
        }

        // Grading portion
        private (int correct, int incorrect, List<int> incorrectQuestions) EvaluateExam(char[] studentAnswers)
        {
            int correctCount = 0;
            int incorrectCount = 0;
            List<int> incorrectQuestions = new List<int>();

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                // Does it match the grade key
                if (studentAnswers[i] == correctAnswers[i]) // Matches/correct
                {
                    correctCount++;
                }
                else
                {
                    incorrectQuestions.Add(i + 1); // Does not match/incorrect
                    incorrectCount++;
                }
            }

            return (correctCount, incorrectCount, incorrectQuestions);
        }

        private void ShowResults((int correct, int incorrect, List<int> incorrectQuestions) results)
        {
            // Could not get textbox to not have all the words jumbled so using string builder for formatting
            txtResults.Clear();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Grading Results are as follows-");
            sb.AppendLine($"Correct Answers: {results.correct}");
            sb.AppendLine($"Incorrect Answers: {results.incorrect}");

            bool passed = results.correct >= 15;
            sb.AppendLine(passed ? "The student passed the exam." : "The student failed the exam.");

            if (results.incorrectQuestions.Count > 0)
            {
                sb.AppendLine($"Questions answered incorrectly: {string.Join(", ", results.incorrectQuestions)}");
            }

            txtResults.AppendText(sb.ToString());
        }

        // Exit button 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the application
        }

        // Clear button 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Clear(); // Clears the results from the TextBox
            studentAnswers = null; // Reset the student answers
            MessageBox.Show("Results cleared. Load a new file to grade or exit", "Reload");
        }
    }
}
