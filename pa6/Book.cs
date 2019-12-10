using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa6
{
    class Book
    {
        public string cwid { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string cover { get; set; }
        public int length { get; set; }
        public int copies { get; set; }
        public string _id { get; set; }
        public Book(string cwid, string isbn, string title, string author, string genre, string cover, int length, int copies, string id)
        {
            this.cwid = cwid;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.cover = cover;
            this.length = length;
            this.copies = copies;
            _id = id;
        }
        public Book()
        {

        }

        public override string ToString()
        {
            return this.title;
        }
    }
    
}
