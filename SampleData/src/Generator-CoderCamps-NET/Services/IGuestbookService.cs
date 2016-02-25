using System.Collections.Generic;
using Generator_CoderCamps_NET.Models;

namespace Generator_CoderCamps_NET.Services
{
    public interface IGuestbookService
    {
        IList<GuestbookEntry> ListEntries();
        void SaveEntry(GuestbookEntry entry);
    }
}