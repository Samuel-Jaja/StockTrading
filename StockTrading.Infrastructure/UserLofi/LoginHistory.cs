using StockTrading.Core.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockTrading.Infrastructure.NewFolder
{
    internal class LoginHistory
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime EventTime { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public string? EventType { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
