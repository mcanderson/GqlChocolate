using GqlChocolate.Database;
using GqlChocolate.Entities;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.GraphQL
{
    public class LocationQueries
    {
        // GetLocations: Return a list of all locations
        // Notice the [Service]. It's an auto hook up from HotChocolate
        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public async Task<List<Locations>> GetLocations([Service] MyDbContext dbContext) =>
          await dbContext
            .Location
            .AsNoTracking()
            .OrderBy(o => o.Name)
            .ToListAsync();

        // GetLocation: Return a list of locations by location code
        [UseFirstOrDefault]
        [UseSelection]
        public async Task<List<Locations>> GetLocation([Service] MyDbContext dbContext, string code) =>
          await dbContext
            .Location
            .AsNoTracking()
            .Where(w => w.Code == code)
            .OrderBy(o => o.Name)
            .ToListAsync();
    }
}

