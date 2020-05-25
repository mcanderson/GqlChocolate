using GqlChocolate.Entities;
using GqlChocolate.GraphQL.Types;
using HotChocolate.Types;

namespace GqlChocolate.GraphQL
{
    public class LocationMutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            //  base.Configure(descriptor);

            //    TODO fix this code
            descriptor.Field(f => f.AddLocation(default, default))
              .Type<LocationType>()
              .Argument("input", a => a.Type<NonNullType<LocationInputType>>());

            //descriptor
            //  .Field(f => f.GetLocation(default, default))
            //  .Argument("code", a => a.Type<StringType>());
        }
    }
}
