using System.Collections.Generic;
using System.Threading.Tasks;
using CitiesDictionary.Shared.Models;

namespace CitiesDictionary.Shared
{
    public interface ICitiesClient
    {
        Task ReceiveCity(City city);
        Task CityDeleted(int id);
        Task Initialize(IEnumerable<City> cities);
    }
}