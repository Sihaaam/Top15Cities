using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Top15Cities.Models
{
    public class WishList
    {
        public int WishListId { get; set; }
        public int CityId { get; set; }
        public int UserId { get; set; }
    }
}