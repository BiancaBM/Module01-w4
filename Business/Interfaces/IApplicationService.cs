using Business.Entities;
using Business.Enums;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IApplicationService
    {
        IEnumerable<Post> SortPostsByDate(SortDirection sortDirection);
    }
}
