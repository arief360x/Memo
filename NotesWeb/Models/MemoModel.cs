using System.ComponentModel.DataAnnotations;

namespace NotesWeb.Models
{
    public class MemoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MemoCategory { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string MemoContent { get; set; }
        public DateTime MemoCreatedTime { get; set; } = DateTime.Now;

    }
}
