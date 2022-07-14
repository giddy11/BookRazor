using System.ComponentModel.DataAnnotations;

namespace BookList.Model
{
    public class Book : BaseEntity
    {
        [Required]
        public virtual string? Name { get; set; }
        public virtual string? Author { get; set; }
    }
}