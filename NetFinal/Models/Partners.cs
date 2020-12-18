using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetFinal.Models
{
    public class Partners
    {
        public Partners(int PartnerID, string CompanyName, string Description, string Link)
        {
            this.PartnerID = PartnerID;
            this.CompanyName = CompanyName;
            this.Description = Description;
            this.Link = Link;
        }

        public Partners()
        {
        }

        [Key]
        [Remote(action: "ValidatePartnerId", controller: "Partners")]
        public int PartnerID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }


        public void setPartnerID(int ID)
        {
            this.PartnerID = ID;
        }
        public int getPartnerID()
        {
            return this.PartnerID;
        }

        public void setCompanyName(string name)
        {
            this.CompanyName = name;
        }
        public string getCompanyName()
        {
            return this.CompanyName;
        }

        public void setDescription(string desc)
        {
            this.Description = desc;
        }
        public string getDescription()
        {
            return this.Description;
        }

        public void setLink(string link)
        {
            this.Link = link;
        }
        public string getLink()
        {
            return this.Link;
        }
    }
}
