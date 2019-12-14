using System.Linq;
using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant
                    {
                         Id = 1,
                         Name ="Scott's Pizza",
                         Location = "MaryLand",
                         Cuisine = CuisineType.Italian
                    },
                    new Restaurant
                    {
                         Id = 2,
                         Name ="Tadka Indian Cuisine",
                         Location = "Houston",
                         Cuisine = CuisineType.Indian
                    }
                    ,
                    new Restaurant
                    {
                         Id = 3,
                         Name ="El Cantina",
                         Location = "Austin",
                         Cuisine = CuisineType.Mexican
                    },
                    new Restaurant
                    {
                         Id = 4,
                         Name ="Fadis",
                         Location = "Houston",
                         Cuisine = CuisineType.None
                    }
                };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
