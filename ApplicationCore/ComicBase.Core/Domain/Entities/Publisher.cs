using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicBase.Core.Domain.Entities
{
    public class Publisher
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string SiteUrl { get; set; }
    }
}
