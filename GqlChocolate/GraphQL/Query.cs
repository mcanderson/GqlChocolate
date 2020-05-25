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
    public class Query
    {
        // Changes to make project more like this: https://dev.to/michaelstaib/get-started-with-hot-chocolate-and-entity-framework-e9i
        /// <summary>
        /// Gets all students.
        /// </summary>
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public async Task<List<Locations>> GetLocations([Service] MyDbContext dbContext) =>
            await dbContext.Location
            .AsNoTracking()
            .OrderBy(o => o.Name)
            .ToListAsync();
    }
 }

