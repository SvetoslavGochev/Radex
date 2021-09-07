namespace Radex.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public string Descriptions { get; set; }

        public DateTime ActiveForm { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }
    }

}
