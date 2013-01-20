using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProdocNET.Models;
using ProdocNET.Models.Abstract;

namespace ProdocNET.Controllers
{
    public class BrowseController : ApiController
    {
        private IDocumentsRepository documentsRepository { get; set; }
        private ICategoriesRepository categoriesRepository { get; set; }
        private IHistoryRepository historyRepository { get; set; }

        public BrowseController(IDocumentsRepository documentsRepository, ICategoriesRepository categoriesRepository, IHistoryRepository historyRepository)
        {
            this.documentsRepository = documentsRepository;
            this.categoriesRepository = categoriesRepository;
            this.historyRepository = historyRepository;
        }

        public IEnumerable<Document> GetDocumentsByCategoryName(String categoryName)
        {
            return documentsRepository.GetDocumentsByCategoryName(categoryName);
        } 



    }
}
