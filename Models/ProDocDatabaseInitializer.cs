using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProdocNET.Models
{
    public class ProDocDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProDocContext>
    {
        protected override void Seed(ProDocContext context)
        {
            var rootId = context.Categories.Add(new Category
                {
                    Name = "Programming",
                    Children = new List<Category>()
                }).Id;
            var childCategory = context.Categories.Add(new Category
                {
                    Name = "C#",
                    ParentId = rootId
                });
            context.SaveChanges();
            var c = (from category in context.Categories
                    where category.Id.Equals(rootId)
                    select category).FirstOrDefault();
            c.Children.Add(childCategory);
            context.SaveChanges();
            var document = context.Documents.Add(new Document
                {
                    AddedAtDate = DateTime.Now,
                    Content = @"<!DOCTYPE html>
                                <html>
	                                <head>
	                                </head>
	                                <body>
		                                <h5>C#</h5>
	                                </body>
                                </html>",
                                        Description = "About C#",
                                        Title = "C#",
                                        CategoryId = childCategory.Id
                });
            context.SaveChanges();
        }
    }
}