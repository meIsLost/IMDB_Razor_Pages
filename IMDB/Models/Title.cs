﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPages_IMDB.Models
{
    public partial class Title
    {
        public Title()
        {
            DirectorForTitles = new HashSet<DirectorForTitle>();
            NameKnownForTitles = new HashSet<NameKnownForTitle>();
            TitleGenres = new HashSet<TitleGenre>();
            WriterForTitles = new HashSet<WriterForTitle>();
        }

        [Key]
        [Column("tconst")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tconst { get; set; }
        [Column("titleTypeId")]
        public int? TitleTypeId { get; set; }
        [Required]
        [Column("primaryTitle")]
        public string PrimaryTitle { get; set; }
        [Column("originalTitle")]
        public string OriginalTitle { get; set; }
        [Column("isAdult")]
        public bool? IsAdult { get; set; }
        [Column("startYear")]
        public int? StartYear { get; set; }
        [Column("endYear")]
        public int? EndYear { get; set; }
        [Column("runtime")]
        public int? Runtime { get; set; }

        [ForeignKey("TitleTypeId")]
        [InverseProperty("Titles")]
        public virtual TitleType TitleType { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<DirectorForTitle> DirectorForTitles { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<NameKnownForTitle> NameKnownForTitles { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }
        [InverseProperty("TconstNavigation")]
        public virtual ICollection<WriterForTitle> WriterForTitles { get; set; }
    }
}