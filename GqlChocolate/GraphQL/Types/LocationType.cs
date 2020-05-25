using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GqlChocolate.Entities;

namespace GqlChocolate.GraphQL.Types
{
    public class LocationType : ObjectType<Locations>
    {
        protected override void Configure(IObjectTypeDescriptor<Locations> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(a => a.ID)
                .Type<IdType>();
            descriptor.Field(a => a.Name)
                .Type<StringType>();
            descriptor.Field(a => a.Code)
                .Type<StringType>();
            descriptor.Field(a => a.Active)
                .Type<BooleanType>();

        }
        //[GraphQLType(typeof(NonNullType<IdType>))]
        //public int Id { get; set; }
        //[GraphQLNonNullType]
        //public string Name { get; set; }
        //[GraphQLNonNullType]
        //public string Code { get; set; }
        //[GraphQLNonNullType]
        //public bool Active { get; set; }
    }
}
