using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastFoodOrders.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Compositions { get; set; }
        public string Price { get; set; }
        public string PhotoFilePath { get; set; }
    }
}
