using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Ticket Title")]
        public string TicketTitle { get; set; }

        public string Description { get; set; }

        [Required]
        [DisplayName("Ticket Code")]
        public string ISBN { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [DisplayName("Ticket Price")]
        public double TicketPrice { get; set; }

        [Required]
        public string Location  { get; set; }



        //[Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }
    }
}
