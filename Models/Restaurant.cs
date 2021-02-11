using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment4.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            ResRanking = rank;
        }

        [Required]
        public int ResRanking { get; set; }
        [Required]
        public string ResName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string ResAddress { get; set; }
        public string ResPhone { get; set; }
        public string ResLink { get; set; } = "Coming soon";

        public static Restaurant[] GetRestaurant()
        {
            Restaurant r1 = new Restaurant(1)
            {
                //ResRanking = 1,
                ResName = "Don Joaquin's",
                FavDish = "Chicken Tacos",
                ResAddress = "123 Cougar Boulevard",
                ResPhone = "801-111-1111",
                ResLink = "donjoaquinstacos.com"

            };
            Restaurant r2 = new Restaurant(2)
            {
                //ResRanking = 2,
                ResName = "Pita Pit",
                FavDish = "Chicken Pesto Pita",
                ResAddress = "200 Cougar Boulevard",
                ResPhone = "801-222-2222",
                //ResLink = "pitapit.com"

            };
            Restaurant r3 = new Restaurant(3)
            {
                //ResRanking = 3,
                ResName = "Founding Flavors Ice Cream",
                FavDish = "Constitutional Crunch",
                ResAddress = "800 N 900 E",
                ResPhone = "801-333-3333",
                ResLink = "foundingflavors.com"

            };
            Restaurant r4 = new Restaurant(4)
            {
                //ResRanking = 4,
                ResName = "Two Jacks Pizza",
                //FavDish = "Personal Cheese Pizza",
                ResAddress = "123 Center Street",
                ResPhone = "801-444-4444",
                ResLink = "twojacks.com"

            };
            Restaurant r5 = new Restaurant(5)
            {
                //ResRanking = 5,
                ResName = "Dirty Chicken",
                FavDish = "Dirty Chicken Sandwich",
                ResAddress = "500 N 600 E",
                ResPhone = "801-555-5555",
                ResLink = "dirtychicken.com"

            };
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
