using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdocNET.Models.Abstract
{
    public interface IHistoryRepository
    {
        //Create
        void AddHistoryEntry(HistoryEntry historyEntry);
        //Read
        IEnumerable<HistoryEntry> GetHistory();
        //Delete
        void ClearHistory();
    }
}
