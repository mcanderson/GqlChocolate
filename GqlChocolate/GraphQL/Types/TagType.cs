using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL.Types
{
    public class TagType
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }

        [GraphQLNonNullType]
        public string Title { get; set; }
        [GraphQLNonNullType]
        public string Description { get; set; }
        [GraphQLNonNullType]
        public bool Active { get; set; }
    }
}
