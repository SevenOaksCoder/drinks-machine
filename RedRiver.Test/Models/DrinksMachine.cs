using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace RedRiver.Test.Models
{
    public class DrinksMachine : IDrinksMachine
    {
        public List<Drinks> GetAvailableDrinks()
        {
            var file = File.ReadAllText("Drinks_mockDB.json");
            var AvailableDrinks = JsonConvert.DeserializeObject<List<Drinks>>(file);

            return AvailableDrinks;
        }
    }
}
