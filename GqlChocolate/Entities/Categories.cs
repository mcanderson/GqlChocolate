using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Entities
{
    [Table("Categories")]
    public class Categories
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(5)]
        public string Description { get; set; }
        public Uri Url { get; set; }
        public string Icon { get; set; }
        public int? OrderRank { get; set; }

        [Required]
        public bool Active { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<LocationCategoryXwalk> LocationCategoryXwalks { get; set; }
    }
}
