using GqlChocolate.Database;
using GqlChocolate.Entities;
using GqlChocolate.GraphQL.InputTypes;
using GqlChocolate.GraphQL.Types;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Data
{
    public class LocationRepository
    {
        private readonly MyDbContext _dbContext;

        public LocationRepository(MyDbContext repository)
        {
            _dbContext = repository;
        }
        public async Task<Locations> AddLocation(Locations location)
        {
            _dbContext.Location.Add(location);
            var results = await _dbContext.SaveChangesAsync();
            return location;
        }
    }
}
