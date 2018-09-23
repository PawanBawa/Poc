using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Akqa.Models
{
    public class UserData
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
       
        public string PriceinWord { get; set; }
        [Required(ErrorMessage = "Price  is required")]
        [Range(1, 100000000, ErrorMessage = "Price must be between 1 and 1000000000")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }

    public class UserDataContext : DbContext
    {
        public DbSet<UserData> Users { get; set; }
    }

}