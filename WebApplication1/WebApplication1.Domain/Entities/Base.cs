
using System;

namespace WebApplication1.Domain.Entities
{
    public class Base
    {
        public string Id { get; set; }

        public Boolean IsActivity { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
