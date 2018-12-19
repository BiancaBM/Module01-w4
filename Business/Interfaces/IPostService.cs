using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IPostService
    {
       IEnumerable<Post> GetAll();
       void Insert(Post postToInsert);
    }
}
