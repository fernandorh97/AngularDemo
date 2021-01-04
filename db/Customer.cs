﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace demo_app.db
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
