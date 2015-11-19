using System.IO;

namespace SystemIO.Helpers
{
    public class DirTools
    {
        public void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
               DirectoryInfo di = Directory.CreateDirectory(path); 
            }
        }

        public void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
            {
               Directory.Delete(path,true); 
            }
        }

        public void MoveFolder(string pathFrom, string pathTo)
        {
            if (Directory.Exists(pathFrom))
            {
                Directory.Move(pathFrom, pathTo);
            }
        }
    }
}

