using System.IO;

namespace Model.Entities
{
    public class Foto
    {
        public Foto() { }

        public Foto(string pathIn)
        {
            this.pathIn = pathIn;
        }

        public Foto(string pathIn, string pathOut)
        {
            this.pathIn = pathIn;
            this.pathOut = pathOut;
        }

        private string pathIn;
        private string pathOut;

        public string PathIn { get { return pathIn; } set { pathIn = value; } }
        public string PathOut { get { return pathOut; } set { pathOut = value; } }

        public void TransferImage()
        {
            if (pathOut.Equals(pathIn))
                return;

            File.Copy(pathIn, pathOut);
        }
    }
}
