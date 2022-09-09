using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ListOfFriend
    {
        [Required]
        public int Id { get; set; }

        [StringLength(25)]
      
        public string? FName { get; set; }

        public string? Fplace { get; set; }


    }
}
