using System;
using POO_EXERCICIO.NotificationContext;

namespace POO_EXERCICIO.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // SPOF
        }
        public Guid Id { get; set; }
    }
}