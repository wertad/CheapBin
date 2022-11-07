using System.ComponentModel.DataAnnotations;

namespace CheapBin.Models
{
    public class DisplaySnippetModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }


        public string Snippet { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Author { get; set; }
    }
}
