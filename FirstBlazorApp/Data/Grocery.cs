using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data
{
    public class Grocery
    {
        public Grocery(string name, float price)
        {
            Name = name;
            Price = price;
        }

        [Required]
        [StringLength(15, ErrorMessage ="Name should be less then 15 charactors.")]
        public string Name { get; set; }
        [Required]
        [Range(0, 10000, ErrorMessage ="valid price range is (1-00000).")]
        public float Price { get; set; }
    }
}
