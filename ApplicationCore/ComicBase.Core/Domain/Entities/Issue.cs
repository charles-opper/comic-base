﻿using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicBase.Core.Domain.Entities
{
    public class Issue : EntityBase
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public int Volume { get; set; }

        [Required]
        public int IssueNumber { get; set; }

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
