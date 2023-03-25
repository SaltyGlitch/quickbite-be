using System.ComponentModel.DataAnnotations;

namespace QuickBiteBE.Models;

public class CartDish
{
    [Key] public int Id { get; set; }
    [Required] public Dish Dish { get; set; }
    [Required] public int Quantity { get; set; }
}