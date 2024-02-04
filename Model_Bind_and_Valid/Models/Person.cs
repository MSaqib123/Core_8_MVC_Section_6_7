using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Model_Bind_and_Valid.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int age { get; set; }
    }
}
