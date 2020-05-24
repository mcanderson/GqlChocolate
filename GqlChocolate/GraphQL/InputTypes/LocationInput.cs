using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL.InputTypes
{
    public class LocationInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public bool Active { get; set; }
    }
}
