using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProdocNET.Models.Abstract;

namespace ProdocNET.Models.Repos
{
    public class DocumentsRepository: IDocumentsRepository
    {
        private ProDocContext db { get; set; }

        public DocumentsRepository(ProDocContext db)
        {
            this.db = db;
        }

        public DocumentsRepository() : this(new ProDocContext())
        {
            
        }

        public Document AddDocument(Document document)
        {
            throw new NotImplementedException();
        }

        public Document GetDocumentById(Guid id)
        {
            return (from d in db.Documents
                    where d.Id.Equals(id)
                    select d).FirstOrDefault();
        }

        public IEnumerable<Document> GetDocumentsByCategoryName(string name)
        {
            return (from d in db.Documents
                    where d.Title.Equals(name)
                    select d).AsEnumerable();
        }

        public IEnumerable<Document> SearchDocument(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public void DeleteDocument(Document document)
        {
            db.Documents.Remove(document);
        }

        public void DeleteDocumentById(Guid id)
        {
            db.Documents.Remove((from d in db.Documents where d.Id.Equals(id) select d).FirstOrDefault());

        }
    }
}