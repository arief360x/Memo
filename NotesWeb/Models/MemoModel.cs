using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NotesWeb.Models
{
    public class MemoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Memo Category")]
        public string MemoCategory { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [DisplayName("Memo Content")]
        public string MemoContent { get; set; }
        public DateTime MemoCreatedTime { get; set; } = DateTime.Now;

    }
}
