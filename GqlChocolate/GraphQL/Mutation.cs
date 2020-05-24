using AutoMapper;
using GqlChocolate.Database;
using GqlChocolate.Entities;
using GqlChocolate.GraphQL.InputTypes;
using GqlChocolate.GraphQL.Types;
using HotChocolate;
using GqlChocolate.Entities;
using GqlChocolate.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL
{
    public class Mutation
    {

        public Mutation()
        {

        }

        public Locations AddLocation([Service] MyDbContext dbContext, LocationInput input)
        {
            var location = new Locations
            {
                Name = input.Name,
                Code = input.Code,
                Active = input.Active
            };
            dbContext.Location.Add(location);
            dbContext.SaveChanges();

            return location;
        }
    }
}
