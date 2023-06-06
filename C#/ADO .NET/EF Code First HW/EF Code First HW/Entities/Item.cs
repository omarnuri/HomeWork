using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace EF_Code_First_HW;

public class Item
{
    [Key]
    public int Id { set; get; }
    [Required]
    public string Name { set; get; }
    [Required]
    public string Property { get; set; }
    

}