using GqlChocolate.GraphQL.InputTypes;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL.Types
{
    public class LocationInputType : InputObjectType<LocationInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<LocationInput> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(i => i.Name)
                .Type<NonNullType<StringType>>();

            descriptor.Field(i => i.Code)
                .Type<NonNullType<StringType>>();

            descriptor.Field(i => i.Active)
                .Type<NonNullType<BooleanType>>();
        }
    }
}
