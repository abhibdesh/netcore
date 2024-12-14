using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTrainingDayTwo08122024.Models
{
    [Serializable]
    [Table("Book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName {  get; set; }
        public string Genre {  get; set; }
        public int Price {  get; set; }
    }
}
