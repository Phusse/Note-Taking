using System.ComponentModel.DataAnnotations;

namespace NoteAPI.models
{
    public class notes
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubTitle { get; set; }
        [Required]
        public string Date { get; set; }
        [StringLength(100)]
        public string Note { get; set; }
    }
}