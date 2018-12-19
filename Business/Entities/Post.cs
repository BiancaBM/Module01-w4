using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    public class Post
    {
        public string Message { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Post(string message, User createdBy, DateTime createdDate)
        {
            this.Message = message;
            this.CreatedBy = createdBy;
            this.CreatedDate = createdDate;
        }
    }
}
