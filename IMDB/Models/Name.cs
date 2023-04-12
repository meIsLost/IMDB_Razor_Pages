﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPages_IMDB.Models
{
    [Table("names")]
    public partial class Name
    {
        public Name()
        {
            DirectorForTitles = new HashSet<DirectorForTitle>();
            NameKnownForTitles = new HashSet<NameKnownForTitle>();
            NamePrimaryProfessions = new HashSet<NamePrimaryProfession>();
            WriterForTitles = new HashSet<WriterForTitle>();
        }

        [Key]
        [Column("nconst ")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nconst { get; set; }
        [Required]
        [Column("primaryName")]
        public string PrimaryName { get; set; }
        [Column("birthYear")]
        public int? BirthYear { get; set; }
        [Column("deathYear")]
        public int? DeathYear { get; set; }

        [InverseProperty("NconstNavigation")]
        public virtual ICollection<DirectorForTitle> DirectorForTitles { get; set; }
        [InverseProperty("NconstNavigation")]
        public virtual ICollection<NameKnownForTitle> NameKnownForTitles { get; set; }
        [InverseProperty("NconstNavigation")]
        public virtual ICollection<NamePrimaryProfession> NamePrimaryProfessions { get; set; }
        [InverseProperty("NconstNavigation")]
        public virtual ICollection<WriterForTitle> WriterForTitles { get; set; }
    }
}