using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdocNET.Models.Abstract
{
    public interface ICategoriesRepository
    {
        //Create
        Category AddCategory(Category category);
        
        //Read
        Category GetCategoryByName(String name);
        IEnumerable<Category> GetParentCategories(Category category);
        //Delete
        void DeleteCategory(Category category);
        void DeleteCategoryByName(Category category);
    }
}
