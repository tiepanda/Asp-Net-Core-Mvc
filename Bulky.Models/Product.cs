using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string TicketTitle { get; set; }

        [Range(1, 10)]
        [DisplayName("Order Quantity")]
        public int OrderQuantity { get; set; }




        CREATE TABLE [dbo].[Ticket] (
    [ticket_id]   INT             NOT NULL,
    [event_id]    INT             NULL,
    [attendee_id] INT             NULL,
    [price]       DECIMAL (10, 2) NULL,
    [status]      VARCHAR (20)    NULL,
    [ordered_id]  INT             NULL,
    PRIMARY KEY CLUSTERED ([ticket_id] ASC),
    FOREIGN KEY ([ordered_id]) REFERENCES [dbo].[Ordered] ([ordered_id]),
    FOREIGN KEY ([event_id]) REFERENCES [dbo].[Event] ([event_id]),
    FOREIGN KEY ([attendee_id]) REFERENCES [dbo].[Attendee] ([attendee_id])
);
    }
}
