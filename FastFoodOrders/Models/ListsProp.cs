

namespace FastFoodOrders.Models
{
    public class ListsProp : IFoodRepository
    {
        private readonly ClientDbContext _logger;

        List<Client> clientsList = new List<Client>();
        public ListsProp(ClientDbContext logger)
        {
            _logger = logger;
        }

        public List<FoodViewModel> FoodsList()
        {
            var foods = _logger.Foods.ToList();
            List<FoodViewModel> foodsList = new List<FoodViewModel>();

            foreach (var item in foods)
            {
                var fViewModel = new FoodViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Compositions = item.Compositions,
                    Price = item.Price,
                    PhotoFilePath = item.PhotoFilePath
                };
                foodsList.Add(fViewModel);
            }
            return foodsList;
        }

        public List<Client> ClientsList()
        {
            var clients = _logger.Clients.ToList();

            foreach (var client in clients)
            {
                var cViewModel = new Client()
                {
                    Id = client.Id,
                    Fullname = client.Fullname,
                    Username = client.Username,
                    Password = client.Password,
                    Phone = client.Phone
                };
                clientsList.Add(cViewModel);
            }
            return clientsList;
        }
       
        //public Client CreateClients(HomeCreateClientsViewModel homeCreate)
        //{
        //    var clients = _logger.Clients.ToList();
        //    foreach (var client in clients)
        //    {
        //        var cViewModel = new ClientViewModel()
        //        {
                    
        //        };
        //    }
        //}

        public Food GetFood(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetFoods()
        {
            throw new NotImplementedException();
        }

        public Client CreateClients(Client client)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            return clientsList;
        }
    }
}
