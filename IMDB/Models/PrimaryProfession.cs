﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPages_IMDB.Models
{
    public partial class PrimaryProfession
    {
        public PrimaryProfession()
        {
            NamePrimaryProfessions = new HashSet<NamePrimaryProfession>();
        }

        [Key]
        public int PrimaryProfessionId { get; set; }
        [Required]
        public string PrimaryProfessionName { get; set; }

        [InverseProperty("PrimaryProfession")]
        public virtual ICollection<NamePrimaryProfession> NamePrimaryProfessions { get; set; }
    }
}