using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Information
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
