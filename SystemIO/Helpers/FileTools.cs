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

    }
}

