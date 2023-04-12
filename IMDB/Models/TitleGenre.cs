﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPages_IMDB.Models
{
    public partial class TitleGenre
    {
        [Key]
        public int TitleGenreId { get; set; }
        [Column("genreId")]
        public int GenreId { get; set; }
        [Required]
        [Column("tconst")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tconst { get; set; }

        [ForeignKey("GenreId")]
        [InverseProperty("TitleGenres")]
        public virtual Genre Genre { get; set; }
        [ForeignKey("Tconst")]
        [InverseProperty("TitleGenres")]
        public virtual Title TconstNavigation { get; set; }
    }
}