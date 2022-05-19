using System.IO;
using System.Text;

namespace MasaWebApp1.Class
{

    public interface IReader
    {
        public string Reads(string path)
        {
            return "0";
        }
    }
    public class Reader : IReader
    {
        public string Reads(string path)
        {
            FileStream fileStream = new(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new(fileStream,Encoding.UTF8);
            string result=sr.ReadToEnd();
            sr.Close();
            fileStream.Close();
            return result;
        }


    }
}
