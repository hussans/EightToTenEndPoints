using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTenEndPoints.services
{
    public class RestaurantPickerService
    {
        public List<string> italianRestaurants = new List<string> { "Olive Garden", "Buca di Beppo", "Carrabba's", "Macaroni Grill", "The Spaghetti Factory", "Giovanni's", "Cafe Bizou", "Pasta Pomodoro", "Maggiano's", "Pizzeria Mozza" };
        public List<string> chineseRestaurants = new List<string> { "Panda Express", "Pei Wei", "Din Tai Fung", "Joe's Shanghai", "Yard House", "Great Wall", "Sichuan Impression", "The Mandarin", "Hong Kong Cafe", "China Palace" };
        public List<string> mexicanRestaurants = new List<string> { "Taco Bell", "Chipotle", "QDOBA", "Del Taco", "El Pollo Loco", "Casa Oaxaca", "La Vida Verde", "Mi Cocina", "Chuy's", "Fonda San Miguel" };

        public string GetRandomRestaurant(string category)
        {
            Random random = new Random();
            category = category.ToLower();

            if(category == "italian")
            {
                int index = random.Next(italianRestaurants.Count); 
                return "Your random Italian restaurant is: " + italianRestaurants[index];
            }
            else if(category == "chinese")
            {
                int index = random.Next(chineseRestaurants.Count); 
                return "Your random Chinese restaurant is: " + chineseRestaurants[index];
            }
            else if(category == "mexican")
            {
                int index = random.Next(mexicanRestaurants.Count); 
                return "Your random Mexican restaurant is: " + mexicanRestaurants[index];
            }
            else
            {
                return "Invalid category. Please choose 'italian', 'chinese', or 'mexican'.";
            }
        }
    }
}