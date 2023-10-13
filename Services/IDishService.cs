using RestaurantAPI.Models;

namespace RestaurantAPI.Services
{
    public interface IDishService
    {
        int Create(int restaurantId, CreateDishDto dto);
        List<DishDto> GetAll(int restaurantId);
        DishDto GetById(int restaurantId, int dishId);
        void RemoveAll(int restaurantId);
    }
}