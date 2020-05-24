using HotChocolate.Types;

namespace GqlChocolate.GraphQL
{
    public class LocationQueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            base.Configure(descriptor);

            descriptor
              .Field(f => f.GetLocations(default));

              descriptor
                .Field(f => f.GetLocation(default, default))
                .Argument("code", a => a.Type<StringType>());
        }
    }
}
