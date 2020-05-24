using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Resolvers
{
    [GraphQLResolverOf(typeof(Entities.Locations))]
    [GraphQLResolverOf("Mutation")]
    public class LocationResolvers
    {
    }
}
