using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Models;

namespace BlogPlatform.Extensions
{
    public interface ISelectList
    {
        IEnumerable<Content> GetAllContent();
     //   IEnumerable<Category> GetAllCategories();
    }
}

