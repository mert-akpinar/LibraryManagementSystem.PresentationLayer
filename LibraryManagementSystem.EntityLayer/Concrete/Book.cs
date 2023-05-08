using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.EntityLayer.Concrete
{
	public class Book
	{
		public int BookID { get; set; }
		public string BookTitle { get; set; }
		public string AuthorName { get; set; }
		public int PageCount { get; set; }
		public string publishing { get; set; }
		public DateTime RelaseDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
