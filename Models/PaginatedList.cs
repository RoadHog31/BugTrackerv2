using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerv2.Models
{
    public class PaginatedList<T> : List<T>
    {
        //Properties with private sset. 
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        //Constructor - for init of properties. 
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            this.PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            //Adds elements to the collection List<T>. 
            this.AddRange(items);
        }

        //Navigate to next page of rows
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);

            }
        }

        //Navigate to previous page of rows. 
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);

            }
        }

        //The CreateAsync method in the preceding code takes page size and page number and applies the appropriate Skip and Take statements to the IQueryable. When ToListAsync is called on the IQueryable, it returns a List containing only the requested page. The properties HasPreviousPage and HasNextPage are used to enable or disable Previous and Next paging buttons.
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(
                (pageIndex - 1) * pageSize)
                .Take(pageSize).ToListAsync();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}