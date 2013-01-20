using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProdocNET.Models.Abstract;

namespace ProdocNET.Models
{
    public class CategoriesRepository:ICategoriesRepository
    {
        private ProDocContext db { get; set; }

        public CategoriesRepository() : this(new ProDocContext())
        {
            
        }

        public CategoriesRepository(ProDocContext db)
        {
            this.db = db;
        }

        public Category AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryByName(string name)
        {
            return (from category in db.Categories
                   where category.Name.Equals(name)
                   select category).FirstOrDefault();
        }

        public IEnumerable<Category> GetParentCategories(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategoryByName(Category category)
        {
            throw new NotImplementedException();
        }
    }   
}