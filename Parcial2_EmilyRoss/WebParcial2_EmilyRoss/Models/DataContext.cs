using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebParcial2_EmilyRoss.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebParcial2_EmilyRoss.Models.Friend> Friends { get; set; }
    }
}