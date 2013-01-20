using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdocNET.Models.Abstract
{
    public interface IDocumentsRepository
    {
        //Create
        Document AddDocument(Document document);
        //Read
        Document GetDocumentById(Guid id);//
        IEnumerable<Document> GetDocumentsByCategoryName(String name);//For browse
        IEnumerable<Document> SearchDocument(String searchQuery);//For search
        //Delete
        void DeleteDocument(Document document);
        void DeleteDocumentById(Guid id);
    }
}
