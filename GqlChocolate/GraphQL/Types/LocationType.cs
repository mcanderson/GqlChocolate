﻿using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL.Types
{
    public class LocationType
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }
        [GraphQLNonNullType]
        public string Name { get; set; }
        [GraphQLNonNullType]
        public string Code { get; set; }
        [GraphQLNonNullType]
        public bool Active { get; set; }
    }
}
