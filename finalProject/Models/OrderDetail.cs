//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &﹛Pui in Kwok & Yang Li
//Description: This model will get the info from related db and save it in the placehold

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Models
{
    public class OrderDetail
    {

        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}