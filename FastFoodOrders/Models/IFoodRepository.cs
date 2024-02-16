namespace FastFoodOrders.Models
{
    public interface IFoodRepository
    {
        Food GetFood(int Id);
        List<Client> GetClients();
        IEnumerable<Food> GetFoods();
        Client CreateClients (Client client); 
    }
}
