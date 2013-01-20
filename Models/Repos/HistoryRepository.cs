using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProdocNET.Models.Abstract;

namespace ProdocNET.Models.Repos
{
    public class HistoryRepository:IHistoryRepository
    {
        public void AddHistoryEntry(HistoryEntry historyEntry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HistoryEntry> GetHistory()
        {
            throw new NotImplementedException();
        }

        public void ClearHistory()
        {
            throw new NotImplementedException();
        }
    }
}