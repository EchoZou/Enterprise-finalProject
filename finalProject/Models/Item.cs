//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &¡¡Pui in Kwok & Yang Li
//Description: This model will get the info from related db and save it in the placehold

namespace finalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //get and set all details of item
    public partial class Item
    {
        public int ItemID { get; set; }

        public int MenuID { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public decimal Price { get; set; }

        public string URL { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
