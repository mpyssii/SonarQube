using System.Text;

namespace Sonar
{
    public class ResourceService
    {
        private FileStream fs; // Noncompliant; Dispose or Close are never called

        public void OpenResource(string path)
        {
            this.fs = new FileStream(path, FileMode.Open);
        }

        public void WriteToFile(string path, string text)
        {
            var fs = new FileStream(path, FileMode.Open); // Noncompliant
            var bytes = Encoding.UTF8.GetBytes(text);
            fs.Write(bytes, 0, bytes.Length);
        }
    }
}
