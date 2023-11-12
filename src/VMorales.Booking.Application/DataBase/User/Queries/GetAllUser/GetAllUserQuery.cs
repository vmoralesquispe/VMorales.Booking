using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace VMorales.Booking.Application.DataBase.User.Queries.GetAllUser
{
    public class GetAllUserQuery: IGetAllUserQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllUserQuery(IDataBaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<List<GetAllIUserModel>> Execute()
        {
            var listEntity = await _databaseService.User.ToListAsync();
            return _mapper.Map<List<GetAllIUserModel>>(listEntity);
        }
    }
}
