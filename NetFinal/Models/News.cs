using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetFinal.Models
{
    public class News
    {
        public News(int NewsID, string Title, string Text)
        {
            this.NewsID = NewsID;
            this.Title = Title;
            this.Text = Text;
        }

        public News()
        {
        }

        [Remote(action: "ValidateNewsId", controller: "News")]
        public int NewsID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        //add link to the food/company

        public void setNewsID(int ID)
        {
            this.NewsID = ID;
        }
        public int getID()
        {
            return this.NewsID;
        }

        public void setTitle(string Title)
        {
            this.Title = Title;
        }
        public string getTitle()
        {
            return this.Title;
        }

        public void setText(string Text)
        {
            this.Text = Text;
        }
        public string getText()
        {
            return this.Text;
        }
    }
}
