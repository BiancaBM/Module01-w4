using Business.Entities;
using Business.Enums;
using Business.Interfaces;
using Business.Services;
using System.Collections.Generic;

namespace Module01_w4
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationService applicationService = new ApplicationService();
            IEnumerable<Post> sortedPosts = applicationService.SortPostsByDate(SortDirection.Asc);
        }
    }
}
