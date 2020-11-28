using System.Linq;
using System.Threading.Tasks;
using CitiesDictionary.Server.DataService;
using CitiesDictionary.Shared;
using CitiesDictionary.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace CitiesDictionary.Server.Hubs
{
    public sealed class CitiesHub : Hub<ICitiesClient>
    {
        private Context context;

        public CitiesHub(Context context)
        {
            this.context = context;
        }

        public async Task SaveCity(City city)
        {
            context.Cities.Update(city);
            context.SaveChanges();
            await Clients.All.ReceiveCity( city);
        }

        public async Task DeleteCity(int id)
        {
            var city = context.Cities.Find(id);
            context.Cities.Remove(city);
            context.SaveChanges();
            await Clients.All.CityDeleted(id);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.Initialize(context.Cities.AsEnumerable());
            await base.OnConnectedAsync();
        }
    }
}
