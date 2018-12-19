using Business.Entities;
using Business.Enums;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class ApplicationService : IApplicationService
    {
        public IEnumerable<Post> SortPostsByDate(SortDirection sortDirection)
        {
            IPostService postService = new PostService();
            IEnumerable<Post> allPosts = postService.GetAll();

            if(sortDirection == SortDirection.Asc)
            {
                allPosts = allPosts.OrderBy(x => x.CreatedDate);
            } else
            {
                allPosts = allPosts.OrderByDescending(x => x.CreatedDate);
            }

            return allPosts;
        }
    }
}
