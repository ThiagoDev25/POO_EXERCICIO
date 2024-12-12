using System.Security.Cryptography.X509Certificates;

namespace POO_EXERCICIO.ContentContext 
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid(); // SPOF
        }


        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}