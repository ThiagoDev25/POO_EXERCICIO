using POO_EXERCICIO.SharedContext;

namespace POO_EXERCICIO.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
    }

}