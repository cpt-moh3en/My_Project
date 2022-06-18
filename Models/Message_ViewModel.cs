using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Message_ViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameFamily { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserMessage { get; set; }
        [Required]   
        public string Time { get; set; }       
    }
}