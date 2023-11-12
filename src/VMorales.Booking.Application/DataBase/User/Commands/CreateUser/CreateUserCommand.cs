using AutoMapper;
using VMorales.Booking.Domain.Entities.User;

namespace VMorales.Booking.Application.DataBase.User.Commands.CreateUser
{
    public class CreateUserCommand: ICreateUserCommand
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public CreateUserCommand(IDataBaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<CreateUserModel> Execute(CreateUserModel model)
        {
            var entity = _mapper.Map<UserEntity>(model);
            await _databaseService.User.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
