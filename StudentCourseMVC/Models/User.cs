﻿using System.ComponentModel.DataAnnotations;

namespace StudentCourseMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; } // Admin, Manager, Salesman
    }
}
