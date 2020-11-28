using System;
using System.ComponentModel.DataAnnotations;

namespace CitiesDictionary.Shared.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int Population { get; set; }

        public DateTime FoundationDate { get; set; }
    }
}
