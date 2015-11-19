using System;
using System.IO;

namespace SystemIO.Helpers
{
    public class FileTools
    {
        public string CreateFile(string filePath)
        {
            StreamWriter sw = File.CreateText(filePath);
            sw.Close();
            return "Filen er oprettet";
        }

        public string DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return "Filen er nu slettet!";
            }
            else
            {
                return "Filen ( " + filePath + " ) findes ikke i mappen!!!";
            }
            
        }

        public void WritToFile(string path, string text)
        {
          
            StreamWriter sw = new StreamWriter(path);

            sw.Write(text + "\n");
            sw.WriteLine("/* Opdateret: " + DateTime.Now + " */\n");
            sw.Close();
        }

        public string ReadFromFile(string path)
        {
            StreamReader sr = File.OpenText(path);
            string input = sr.ReadToEnd();
            sr.Close();

            return input;
        }

        public FileInfo[] GetAllFiles(string path)
        {
            DirectoryInfo myDirectory = new DirectoryInfo(path);
            FileInfo[] files = myDirectory.GetFiles();

            return files;
        }

    }
}

