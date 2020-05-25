using AutoMapper;
using GqlChocolate.Database;
using GqlChocolate.Entities;
using GqlChocolate.GraphQL.InputTypes;
using GqlChocolate.GraphQL.Types;
using GqlChocolate.Data;
using HotChocolate;
using System.Threading.Tasks;
using System;

namespace GqlChocolate.GraphQL
{
    public class Mutation
    {
      //  private readonly IMapper _mapper;
        private readonly LocationRepository _repository; 
        public Mutation(LocationRepository repository)
        {
            //  _mapper = mapper; 
            _repository = repository
                 ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Locations> AddLocation([Service] MyDbContext dbContext, LocationInput input)
        {
            var sqlLocation = new Locations
            {
                Name = input.Name,
                Code = input.Code,
                Active = input.Active
            };

            _repository.AddLocation(sqlLocation);

            return sqlLocation; 
            //dbContext.Location.Add(sqlLocation);
            //dbContext.SaveChangesAsync();

           // var locationType = _mapper.Map<LocationType>(location);

            //return location;
        }
    }
}
