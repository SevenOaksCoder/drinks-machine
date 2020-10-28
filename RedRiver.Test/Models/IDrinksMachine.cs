using System.Collections.Generic;

namespace RedRiver.Test.Models
{
    public interface IDrinksMachine
    {
        List<Drinks> GetAvailableDrinks();
    }
}