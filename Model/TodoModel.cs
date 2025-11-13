using System.ComponentModel.DataAnnotations;

namespace simple_crud.Model
{
    public class TodoModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsDone { get; set; }
    }
}