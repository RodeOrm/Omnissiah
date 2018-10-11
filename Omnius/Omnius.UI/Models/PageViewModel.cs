using System;
using System.Collections.Generic;
using System.Linq;

namespace Omnius.UI.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }
        public string FamilyNameFilter { get; private set; }
        public string NameFilter { get; set; }
        public string PaternalNameFilter { get; set; }

        public PageViewModel(int count, int pageNumber, int pageSize, string familyNameFilter)
        {
            PageNumber = pageNumber;
            FamilyNameFilter = familyNameFilter;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }
}
