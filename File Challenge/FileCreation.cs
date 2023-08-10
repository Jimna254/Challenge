using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Challenge
{
    public class FileCreation
    {
        public void Filecreation() {
            string filePath = "C:\\Users\\jimmy\\Downloads\\C#challenge\\Assignment.txt"; // file path
            string contentToAdd = "My File Challenge and I'm going to ace this.";

            WriteToFile(filePath, contentToAdd);
            

            Console.WriteLine("Just added Some text.");
        }

        static void WriteToFile(string filePath, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
