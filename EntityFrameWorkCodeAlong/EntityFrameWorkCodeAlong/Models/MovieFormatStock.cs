﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class MovieFormatStock
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int FormatId { get; set; }
        public int AmountInStock { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
        [ForeignKey("FormatId")]
        public virtual Format Format { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }                                                                           
}