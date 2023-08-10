using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Challenge
{
    public class Files
    {
        public void working_with_files() {
            string filePath = "C:\\Users\\jimmy\\Downloads\\C#challenge\\Assignment.txt"; //  My file path
            int wordCount = CountWords(filePath);

            Console.WriteLine($"Number of words in the file: {wordCount}");
        }

        static int CountWords(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");

                return -1; // Error indicator
            }

        }
    }
}
