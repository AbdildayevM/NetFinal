using Microsoft.AspNetCore.Mvc;
using NetFinal.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetFinal.Models
{
    public class User
    {
        public User(int ID, string LastName, string FirstName, long PhoneNumber, string Password, DateTime SignDate)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.PhoneNumber = PhoneNumber;
            this.Password = Password;
            this.SignDate = SignDate;

        }

        public User()
        {
        }

        [Remote(action: "ValidateUserId", controller: "Users")]
        public int ID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CustomDate(ErrorMessage = "Please be careful!")]
        //public ICollection<Order> Orders { get; set; }
        public DateTime SignDate { get; set; }

        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }

        public void setLastName(string last)
        {
            this.LastName = last;
        }
        public string getLastName()
        {
            return this.LastName;
        }

        public void setFirstName(string first)
        {
            this.FirstName = first;
        }
        public string getFirstName()
        {
            return this.FirstName;
        }


        public void setPhoneNumber(long phone)
        {
            this.PhoneNumber = phone;
        }
        public long getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }
        public string getPassword()
        {
            return this.Password;
        }
    }
}
