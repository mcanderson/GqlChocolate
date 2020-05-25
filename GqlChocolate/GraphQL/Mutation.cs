using AutoMapper;
using GqlChocolate.Database;
using GqlChocolate.Entities;
using GqlChocolate.GraphQL.InputTypes;
using GqlChocolate.GraphQL.Types;
using HotChocolate;
using System.Threading.Tasks;
using System;

namespace GqlChocolate.GraphQL
{
    public class Mutation
    {

        // Changes to make project more like this: https://dev.to/michaelstaib/get-started-with-hot-chocolate-and-entity-framework-e9i
        /// <summary>
        /// Gets all students.
        /// </summary>
        public async Task<Locations> AddLocation([Service] MyDbContext dbContext, LocationInput input) {
            var tempInput = new Entities.Locations
            {
                Name = input.Name,
                Code = input.Code,
                Active = input.Active

            }; 
            dbContext.Location.Add(tempInput);
            dbContext.SaveChanges();
            // TODO figure out how to get the ID # and assign back to the entity?
//             tempInput.ID = dbContext.Location.
            return tempInput; 

        }
    }
}
