using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetFinal.Models
{
    public class Order
    {
        public Order(int ID, int ClientID, int FoodID, string Address, int Numb, double TotalCost, DateTime Ordertime)
        {
            this.ID = ID;
            this.ClientID = ClientID;
            this.FoodID = FoodID;
            this.Address = Address;
            this.Numb = Numb;
            this.TotalCost = TotalCost;
            this.Ordertime = Ordertime;
        }

        public Order()
        {
        }

        [Remote(action: "ValidateOrderId", controller: "Orders")]
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int FoodID { get; set; }
        [Required]
        public string Address { get; set; }
        public int Numb { get; set; } //number of ordered food
        public double TotalCost { get; set; }
        public DateTime Ordertime { get; set; }
        //public User User { get; set; }
        //public ICollection<Food> Foods { get; set; }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }

        public void setClientID(int ClientID)
        {
            this.ClientID = ClientID;
        }
        public int getClientID()
        {
            return this.ClientID;
        }

        public void setFoodID(int FoodID)
        {
            this.FoodID = FoodID;
        }
        public int getFoodID()
        {
            return this.FoodID;
        }

        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public string getAddress()
        {
            return this.Address;
        }

        public void setNumb(int Numb)
        {
            this.Numb = Numb;
        }
        public int getNumb()
        {
            return this.Numb;
        }

        public void setTotalCost(double cost)
        {
            this.TotalCost = cost;
        }
        public double getTotalCost()
        {
            return this.TotalCost;
        }
    }
}
