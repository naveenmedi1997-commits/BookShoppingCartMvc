using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    //Genre can have multiple books
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }

        public List<Book> Books { get; set; }
    }
}
