using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage="Display order between 1 to 100")]
        public  string DisplayOrder{get;set;}
        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
