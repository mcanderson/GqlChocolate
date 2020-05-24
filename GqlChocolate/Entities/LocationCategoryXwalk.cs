using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Entities
{
    public partial class LocationCategoryXwalk
    {
        public LocationCategoryXwalk()
        {

        }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("LocationObj")]
        public int LocationId { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("CategoryObj")]
        public int CategoryId { get; set; }
        public Locations LocationObj { get; set; }
        public Categories CategoryObj { get; set; }
    }
}
