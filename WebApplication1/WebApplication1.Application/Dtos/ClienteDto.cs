using System;

namespace WebApplication1.Application.Dtos
{
    public class ClienteDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public Boolean IsActivity { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

    }
}
