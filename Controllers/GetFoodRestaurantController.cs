using Microsoft.AspNetCore.Mvc;
using RestaurantDishesAPI.Models;
namespace RestaurantDishesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetFoodRestaurantController : Controller
    {
        [HttpGet("getFood")]
        public async Task<ActionResult<List<Dish>>> GetDishes()
        {
            Dishes dishes = new Dishes();
            List<Dish> listDishes = await dishes.dishesGet();
            return listDishes;
        }

        [HttpGet("getDish/{id}")]
        public async Task<ActionResult<Dish>> GetDish(int id)
        {
            Dishes dishes = new Dishes();
            Dish dish = await dishes.GetDish(id);
            return dish;
        }

        [HttpPost("/postDish/{nameDish}+{descriptionDish}+{typeDish}+{ingredients}+{timeGetsReady}+{Price}+{img}")]
        public async void PostDish(string? nameDish, string? descriptionDish, string? typeDish, string? ingredients, string? timeGetsReady, int? Price, string? img)
        {
            Dishes dishes = new Dishes();
            dishes.AddDish(nameDish, descriptionDish, typeDish, ingredients, timeGetsReady, Price, img);
        }

    }
}
