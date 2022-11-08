using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class SnippetModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Author { get; set; }
    }
}
