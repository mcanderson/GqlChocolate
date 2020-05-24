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
                .Type<IdType>()
                .Resolver(ctx => "id");
            descriptor.Field(a => a.Name)
                .Type<StringType>()
                .Resolver(ctx => "name"); 
            descriptor.Field(a => a.Code)
                .Type<StringType>()
                .Resolver(ctx => "code"); 
            descriptor.Field(a => a.Active)
                .Type<BooleanType>()
                .Resolver(ctx => "isActive");
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
