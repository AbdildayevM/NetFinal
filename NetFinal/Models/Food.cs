using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetFinal.Models
{
    public class Food : IValidatableObject//-Order(m-1). News(1-1)
    {
        public Food(int FoodID, string Title, int Cost)
        {
            this.FoodID = FoodID;
            this.Title = Title;
            this.Cost = Cost;
        }

        public Food()
        {
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Title))
                errors.Add(new ValidationResult("Title not specified"));

            if (this.Cost < 0)
                errors.Add(new ValidationResult("Invalid cost"));

            return errors;
        }

        [Remote(action: "ValidateFoodId", controller: "Foods")]
        public int FoodID { get; set; }

        public string Title { get; set; }
        [Required]
        public int Cost { get; set; }
        //public Order Order { get; set; }


        public void setFoodID(int ID)
        {
            this.FoodID = ID;
        }
        public int getFoodID()
        {
            return this.FoodID;
        }

        public void setTitle(string title)
        {
            this.Title = title;
        }
        public string getTitle()
        {
            return this.Title;
        }

        public void setCost(int cost)
        {
            this.Cost = cost;
        }
        public int getCost()
        {
            return this.Cost;
        }
    }
}

