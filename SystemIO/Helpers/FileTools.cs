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

    }
}

