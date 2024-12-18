using System.Security.Cryptography.X509Certificates;

namespace POO_EXERCICIO.ContentContext 
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }

    }
}