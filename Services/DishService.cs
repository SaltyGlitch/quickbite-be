using Microsoft.EntityFrameworkCore;
using QuickBiteBE.Data;
using QuickBiteBE.Models;
using QuickBiteBE.Services.Interfaces;

namespace QuickBiteBE.Services;

public class DishService : IDishService
{
    private QuickBiteContext _context { get; set; }

    public DishService(QuickBiteContext context)
    {
        _context = context;
    }
    
    public Task<Dish> GetDishBGetById(int id)
        => _context.Dishes.FirstAsync(dish => dish.Id == id);
    
    public async Task<List<Dish>> GetAllDishes() // Doesn't really make a lot of sense. The restaurants already hold all the Dishes.
        => await QueryAllDishes().ToListAsync();
    
    private IQueryable<Dish> QueryAllDishes()
        => _context.Dishes;
}